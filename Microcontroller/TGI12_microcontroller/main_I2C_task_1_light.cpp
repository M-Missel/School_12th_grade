#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h" 

I2C pcf8574(D14, D15);

int main()
{
    char sendDataLightOne[8] = {
        0b11111110,
        0b11111101,
        0b11111011,
        0b11110111,
        0b11101111,
        0b11011111,
        0b10111111,
        0b01111111
    };

    char sendDataLightTwo[8] = {
        0b01111110,
        0b10111101,
        0b11011011,
        0b11100111,
        0b11101011,
        0b11011101,
        0b10111110
    };

    while (1) {
        for(auto i: sendDataLightOne){
            pcf8574.write(0x40, (char*)&sendDataLightOne[i], 1, false);
            sleep(500);
        }
    }
}

#endif