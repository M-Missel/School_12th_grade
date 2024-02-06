#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <cstdio>

DigitalOut led(LED1);

void timer_init();

int main()
{
    timer_init();

    printf("CPU SystemCoreClock is %d Hz \r\n", SystemCoreClock);
    printf("ARR %d \r\n", TIM6->ARR);

    while (1) {
        if(TIM6->SR != 0){
            led != led;
            TIM6->SR = 0;
        }
    }
}

void timer_init(void){
    RCC->APB1ENR |= 0b10000;
    TIM6->PSC = 31999;
    TIM6->ARR = 99;
    TIM6->CNT = 0;
    TIM6->SR = 0;
    TIM6->DIER = 0;
    TIM6->CR1 &= ~(1<<0);
    TIM6->CR1 |= 1 << 2;
    TIM6->EGR = 1;
}

#endif