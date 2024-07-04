#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <cstdio>

// Blinking rate in milliseconds
#define BLINKING_RATE     3000ms
#define BLINKING_TRUE     true
#define sleep             ThisThread::sleep_for

volatile int sekunden; 

InterruptIn Taste(PA_10);  //Taste auf Ampelshield

BusOut AmpelNS(PA_0, PA_1, PA_4); /* rot, gelb, grün */
BusOut AmpelHS(PB_0, PC_1, PC_0); /* rot, gelb, grün */

Timer debounce;

enum Zustand{
    AUS,
    GRUEN, 
    GELB,
    ROT,
    ROTGELB
};

void switchState();
void entryState(Zustand neuerZustand);
void exitState();
void doState();

Zustand aktuellerZustand;

void isr_Taste(){
   if (debounce.elapsed_time() >= 100ms){
    switchState();
    debounce.reset();
   }
}

void isr_Timer(void){                
  TIM6->SR=0;         
  NVIC_ClearPendingIRQ(TIM6_IRQn);
  sekunden++;
}

void init() { 
    Taste.mode(PullUp);
    Taste.fall(&isr_Taste);
    Taste.enable_irq();
    debounce.start();
    aktuellerZustand = ROT;
    AmpelNS = 0b100;
}

void initTimer(void){
     RCC->APB1ENR |= 1<<4;
     TIM6->PSC=31999;
     TIM6->ARR=999;
     TIM6->CNT=0;
     TIM6->SR=0;
     TIM6->CR1&=~(1<<3);
     TIM6->CR1 |= 1<< 2;
     TIM6->DIER = 1;
     TIM6->CR1 &= ~(1<<0);
     TIM6->EGR = 1;
     NVIC_SetVector(TIM6_IRQn, (uint32_t) &isr_Timer);  
     NVIC_ClearPendingIRQ(TIM6_IRQn);
     NVIC_EnableIRQ(TIM6_IRQn);
}
//===========================================================================================

//todo
void switchState(){
    switch (aktuellerZustand) {
        case AUS:
            entryState(GRUEN); 
            break;
        case GRUEN: 
            if(sekunden >= 5){entryState(GELB);}
            break;
        case GELB: 
            if(sekunden >= 1){entryState(ROT);}
            break;
        case ROT: 
            if(sekunden >= 5){entryState(ROTGELB);}
            break;
        case ROTGELB: 
            if(sekunden >= 1){entryState(GRUEN);}
            break;
    }
}

void entryState(Zustand neuerZustand){
    
    exitState();

    switch (neuerZustand) {
        case GRUEN: AmpelHS = 0b001; sekunden = 0; break;
        case GELB: AmpelHS = 0b010; sekunden = 0; break;
        case ROT:  AmpelHS = 0b100; sekunden = 0; break;
        case ROTGELB: AmpelHS = 0b110; sekunden = 0; break;
    }

    aktuellerZustand = neuerZustand;
}

void exitState(){
    //No call
}

void doState(){
    switch (aktuellerZustand) {
        case GRUEN: printf("GRUEN"); break;
        case GELB: printf("GELB"); break;
        case ROT: printf("ROT"); break;
        case ROTGELB: printf("ROTGELB"); break;
    }
}

//===========================================================================================
int main() {
  init();
  initTimer();
  while (true) {
      doState();
   sleep(1s);
  }
}






#endif