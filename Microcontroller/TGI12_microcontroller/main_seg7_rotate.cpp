#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <cstdint>

uint8_t flip(uint8_t value);

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
    PortOut seg7Display(PortC, MASK);
    DigitalIn button(PA_6);
    int k = 0;

    while (1) {
        while(button == 1)
            seg7Display.write(flip(seg7values[k]));

        k = k % 9;
        k++;
    }
}

//Teacher proposal
/*
uint8_t flip(uint8_t value){
    uint8_t flippedValue = 0b00000000; //aka uint8_t flippedValue = 0;
    uint8_t flippedA, flippedB, flippedC, flippedD, flippedE, flippedF, flippedG;

    flippedA = (value & 0b00000001) << 3;
    flippedB = (value & 0b00000010) << 3;
    flippedC = (value & 0b00000100) << 3;
    flippedD = (value & 0b00001000) >> 3;
    flippedE = (value & 0b00010000) >> 3;
    flippedF = (value & 0b00100000) >> 3;
    flippedG = (value & 0b01000000);

    flippedValue = flippedA | flippedB | flippedC | flippedD | flippedE| flippedF | flippedG;
    return flippedValue;
}
*/

//Own proposal
uint8_t flip(uint8_t value){
    uint8_t flipvalue = 0b00000001, returnValue = (value & flipvalue);

    for(int i = 0; i < 2; i++)
        returnValue += (value & (flipvalue << 1)) << 3;

    for(int i = 0; i < 3; i++)
        returnValue += (value & (flipvalue << 1)) >> 3;

    return returnValue + (value & (flipvalue << 1));
}
#endif