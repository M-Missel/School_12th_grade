#include <cstdio>
#if 0

#include "mbed.h"

#define BLINKING_RATE     3000ms
#define BLINKING_TRUE     true
#define sleep             ThisThread::sleep_for

InterruptIn Taste1(PA_1, PullNone);    //MFS S1 mit PullUp 10k
InterruptIn Taste2(PA_4, PullNone);    //MFS S2 mit PullUp 10k
DigitalIn   Taste3(PB_0, PullNone);    //MFS S3 mit PullUp 10k
DigitalOut led1(D10,1);   //MFS low-aktiv (D10)
DigitalOut led2(D11,1);   //MFS low-aktiv (D11)
DigitalOut led3(D12,1);   //MFS low-aktiv (D12)
DigitalOut led4(D13,1);   //MFS low-aktiv (D13)
//===========================================================================================================
//todo
enum Zustand{
    LED1_AN,
    LED1_AUS,
    LED2_AN,
    LED2_AUS
};

enum Ereignis{
    E_TASTE_1,
    E_TASTE_2
};

Zustand derZustand;
//===========================================================================================================
void switchState(Ereignis e);
void entryState(Zustand neuerZustand);
void exitState();

Timer debounce;  //Timer um die Taster in der ISR zu entprellen

void isr_Taste1(){        //Interrupt-Service-Routine Taste1 -> Ereignis
 if(debounce.elapsed_time() > 100ms){  //entprellen
   switchState(E_TASTE_1);
   debounce.reset();
 }
}

void isr_Taste2(){        //Interrupt-Service-Routine Taste2 -> Ereignis
 if(debounce.elapsed_time() > 100ms){ //entprellen
   switchState(E_TASTE_2);
  debounce.reset();
 }
}
//===========================================================================================================
//todo
void switchState(Ereignis e){
    switch (derZustand) {
        case LED1_AN:
            if(e==Taste1)
                entryState(LED1_AUS);
            break;
        case LED1_AUS:
            switch(e){
                case E_TASTE_1:
                    entryState(LED1_AN);
                    break;
                case E_TASTE_2:
                    entryState(LED2_AN);
                    break;
            }
            break;
        case LED2_AN:
            switch(e){
                case E_TASTE_1:
                    entryState(LED1_AUS);
                    break;
                case E_TASTE_2:
                    entryState(LED2_AUS);
                    break;
            }
            break;
        case LED2_AUS:
            if(e==Taste2)
                entryState(LED2_AN);
            break;
    }
}

//===========================================================================================================
//todo
void entryState(Zustand neuerZustand){
    /*if(derZustand == LED1_AN)
        exitState();
    */
    exitState();

    switch (neuerZustand) {
        case LED1_AN: led1 = 0; break;
        case LED1_AUS: led1= 1; break;
        case LED2_AN: led2 = 0; break;
        case LED2_AUS: led2 = 1; break;
    }

    derZustand = neuerZustand;
}

//===========================================================================================================
//todo
void exitState(){
    switch (derZustand) {
        case LED1_AN: led4 = !led4; break;
        case LED1_AUS: break;
        case LED2_AN: break;
        case LED2_AUS: break;
    }
}

//===========================================================================================================
void init() { 
    Taste1.fall(&isr_Taste1);
    Taste1.enable_irq();
    Taste2.fall(&isr_Taste2);
    Taste2.enable_irq();
    debounce.start();
    entryState(LED1_AN);
}

int main() {
    init(); 
    while (true) {
        //todo
        sleep(500ms);
    }
}

#endif