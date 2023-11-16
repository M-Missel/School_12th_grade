#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"

#define ONESMASK 0x0F
#define TENSMASK 0xF0

DigitalOut seg7_ones_onoff(PC_11, 1);
DigitalOut seg7_tens_onoff(PC_12, 0);
PortOut seg7Display(PortC, MASK);
PortIn dipsSwitch(PortB, MASK);

void showDisplay(int switchValueOnes, int switchValueTens);

const uint8_t seg7values[]={
        0x3F,
        0x06,
        0x5B,
        0x4F,
        0x66,
        0x6D,
        0x7D,
        0x07, 
        0x7F,
        0x67,
        0x77,
        0x7E,
        0x39,
        0x5E,
        0x79,
        0x71
};

int main()
{
    int ones, tens, inputDips;
    dipsSwitch.mode(PullDown);
    while (1) {
        inputDips = dipsSwitch.read();
        ones = inputDips & ONESMASK;
        tens = (inputDips & TENSMASK) >> 4;

        showDisplay(ones, tens);
    }
}

void showDisplay(int switchValueOnes, int switchValueTens){
    seg7_ones_onoff.write(seg7values[switchValueOnes]);
    sleep(10);
    
    seg7_ones_onoff = 0;
    seg7_tens_onoff = 1;
    seg7_tens_onoff.write(seg7values[switchValueTens]);
    sleep(10);

    seg7_tens_onoff = 0;
    seg7_ones_onoff = 1;
}

#endif