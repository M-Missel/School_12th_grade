#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <cstdint>

DigitalOut data(PA_9);
DigitalOut shiftClock(PA_8);
DigitalOut latchClock(PA_5);

const uint8_t seg7Data[] = {
    0x03,
    0x9F,
    0x25,
    0x0D,
    0x99,
    0x49,
    0x41,
    0x1D,
    0x01,
    0x09
};

const uint8_t enableValue[] = {
    0x80,
    0x40,
    0x20,
    0x10
};

void shiftByte(int value);
void latch();

int main()
{
    while (true) {
        shiftByte(seg7Data[1]);
        shiftByte(enableValue[3]);
        latch();

        sleep(1ms);

        shiftByte(seg7Data[2]);
        shiftByte(enableValue[2]);
        latch();
        sleep(1ms);
    }
}

void shiftByte(int value){
    int mask = 0b1;

    for(int i = 0; i < 8; i++){
        if((value & mask) == 1)
            data = 1;
        else
            data = 0;

        shiftClock = 0; 
        shiftClock = 1;

        value = value >> 1;
    }
}

void latch(){
    latchClock = 0;
    latchClock = 1;
}

#endif