#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"

DigitalOut seg7_ones_onoff(PC_11, 1);
PortOut seg7Display(PortC, MASK);
PortIn dipsSwitch(PortB, 0xF);

void showDisplay(int switchValue);

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
        0x75,
        0x7E,
        0x39,
        0x5E,
        0x79,
        0x71
};

int main()
{
    dipsSwitch.mode(PullDown);
    seg7_ones_onoff.write(1);
    while (1) {
        showDisplay(dipsSwitch.read());
    }
}

void showDisplay(int switchValue){
    seg7Display.write(seg7values[switchValue]);
}

#endif