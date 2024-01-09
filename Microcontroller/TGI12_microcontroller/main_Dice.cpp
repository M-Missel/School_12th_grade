#if 1
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <cstdint>

DigitalOut seg7_ones_onoff(PC_11, 1);
DigitalOut seg7_tens_onoff(PC_12, 0);

void showDisplay(int diceValue, int diceCount);

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
        0x67
};

int main()
{
    PortOut seg7display(PortC, MASK);
    DigitalIn button(PA_6);
    uint8_t diceCount = 0, diceValue = 1;

    while (1) {
        if (button != 1) {
            diceValue = diceValue % 6;
            diceValue++;
        }

        if(button == 1 && diceValue == 6){
            if(diceCount < 9)
                diceCount++;
            while (button == 1) {
                showDisplay(diceValue, diceCount);
            }
        }

        showDisplay(diceValue, diceCount);
    }
}

void showDisplay(int diceValue, int diceCount){
    seg7_ones_onoff.write(diceValue);
    sleep(10);
    
    seg7_ones_onoff = 0;
    seg7_tens_onoff = 1;
    seg7_tens_onoff.write(diceCount);
    sleep(10);

    seg7_tens_onoff = 0;
    seg7_ones_onoff = 1;
}

#endif