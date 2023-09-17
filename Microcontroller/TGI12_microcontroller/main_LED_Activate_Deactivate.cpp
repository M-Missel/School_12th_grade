#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"

int main()
{
    DigitalOut led(LED1);

    while(1){
        BLINKING_ON;
        sleep(200ms);
        BLINKING_OFF;
        sleep(3s);
    }
}

#endif