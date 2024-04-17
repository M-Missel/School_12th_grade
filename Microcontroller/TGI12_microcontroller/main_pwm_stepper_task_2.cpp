#if 1
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"

// Blinking rate in milliseconds
#define BLINKING_RATE     3000ms
#define BLINKING_TRUE     true
#define sleep             ThisThread::sleep_for

InterruptIn Taste1(PA_1, PullNone);
InterruptIn Taste2(PA_4, PullNone);
InterruptIn Taste3(PB_0, PullNone);
PwmOut sg90(PB_4);
DigitalOut led(D10, 1);

enum Zustand{
    LEFT,
    MIDDLE,
    RIGHT
};

enum Ereignis{
    E_LEFT,
    E_MIDDLE,
    E_RIGHT
};

Zustand aktuellerZustand;

void init();
void initPWM();
void timer_init();
void isr_timer();
void isr_middle();
void isr_right();
void isr_left();
void blinken();
void blinkenSchnell();
void ausgabe();

void switchState(Ereignis e);
void entryState(Zustand neuerZustand);
void doState();
void exitState();

Timer debounce;

void init(){
    Taste1.fall(&isr_left);
    Taste1.enable_irq();
    Taste2.fall(&isr_middle);
    Taste2.enable_irq();
    Taste3.fall(&isr_right);
    Taste3.enable_irq();
    debounce.start();
    entryState(MIDDLE);
}

void initPWM(){
    sg90.period_ms(20);
}

void isr_timer(){
    TIM6->SR=0;         
    NVIC_ClearPendingIRQ(TIM6_IRQn);
    led = !led;
}

void isr_middle(){
    if(debounce.elapsed_time() > 100ms){
        switchState(E_MIDDLE);
        debounce.reset();
    }
}

void isr_right(){
    if(debounce.elapsed_time() > 100ms){
        switchState(E_RIGHT);
        debounce.reset();
    }
}

void isr_left(){
    if(debounce.elapsed_time() > 100ms){
        switchState(E_LEFT);
        debounce.reset();
    }
}

void blinken(){
    TIM6->ARR = 1999;
}

void blinkenSchnell(){
    TIM6->ARR = 499;
}

void timer_init(void){
    RCC->APB1ENR |= 0b10000;
    TIM6->PSC = 31999;
    TIM6->ARR = 49;
    TIM6->CNT = 0;
    TIM6->SR = 0;
    TIM6->DIER = 1;
    TIM6->CR1&=~(1<<3);
    TIM6->EGR = 1;
    TIM6->CR1 = 1;
    NVIC_SetVector(TIM6_IRQn, (uint32_t) &isr_timer);
    NVIC_EnableIRQ(TIM6_IRQn);
    __enable_irq();
}

void switchState(Ereignis e){
    switch (aktuellerZustand) {
        case MIDDLE:
            switch (e) {
                case E_LEFT:
                    entryState(LEFT);
                    break;
                case E_RIGHT:
                    entryState(RIGHT);
                    break;
            }
            break;
        case LEFT:
            switch (e) {
                case E_MIDDLE:
                    entryState(MIDDLE);
                    break;
                case E_RIGHT:
                    entryState(RIGHT);
                    break;
            }
            break;
        case RIGHT:
            switch(e){
                case E_MIDDLE:
                    entryState(MIDDLE);
                    break;
                case E_LEFT:
                    entryState(LEFT);
                    break;
            }
            break;
    }
}

void entryState(Zustand neuerZustand){
    exitState();

    switch(neuerZustand){
        case LEFT:
            sg90.pulsewidth_us(500);
            blinken();
            doState();
            break;
        case MIDDLE:
            sg90.pulsewidth_us(1500);
            blinkenSchnell();
            doState();
            break;
        case RIGHT:
            sg90.pulsewidth_us(2500);
            blinken();
            doState();
            break;
    }
    aktuellerZustand = neuerZustand;
}

void doState(){
    switch(aktuellerZustand){
        case LEFT:
            printf("Der Motor steht links\n");
            break;
        case MIDDLE:
            printf("Der Motor steht in der Mitte\n");
            break;
        case RIGHT:
            printf("Der Motor steht rechts\n");
            break;
    }
}

void exitState(){
    //TODO
}

int main()
{
    init();
    initPWM();
    timer_init();
    while(true){

    }
}


#endif