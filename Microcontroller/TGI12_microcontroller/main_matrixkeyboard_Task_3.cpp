#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <cstdint>

int main()
{
    PortOut ledband(PortC, MASK);
    DigitalIn button(PA_1);
    button.mode(PullDown);

    uint8_t values[] = {
        0b00000001,
        0b00000010,
        0b00000100,
        0b00001000,
        0b00010000,
        0b00100000,
        0b01000000,
        0b10000000
    };
    uint8_t i = 0;

    while (1) {
        while(button == 0){
            ;
        }
        ledband = values[i];
        i++;
        i = 1 % 8;
        while(button == 1){
            ;
        }
    }
}

#endif