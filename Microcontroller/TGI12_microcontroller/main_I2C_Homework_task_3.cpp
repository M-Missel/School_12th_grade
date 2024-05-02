#if 1
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

/*
    I2C-Adresse: 0x25
    Bitmuster: 10111101
*/
#include "mbed.h" 

I2C pcf8574(D14, D15);

int main()
{
    char sendData[1] = {
        0b10111101
    };

    while (1) {
        pcf8574.write(0x20>>1, (char*)&sendData[0], 1, 0);
    }
}

#endif