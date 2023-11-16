#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"

#define PORTMASK 0xFF
#define ANDMASK 0x1A

PortIn input(PortB, PORTMASK);
DigitalOut led(PC_1, 1);

int main()
{
    int inputValue = 0;
    while (1) {
        inputValue = input.read() & ANDMASK;

        if(inputValue == 26)
            led.write(1);
        else
            led.write(0);
    }
}

#endif