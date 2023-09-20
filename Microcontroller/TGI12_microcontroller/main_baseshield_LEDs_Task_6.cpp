#include <iterator>
#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <cstdint>
PortOut ledband(PortC, MASK);

int main()
{
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

    while (1) {
        for(int i = 0; i < end(values) - begin(values); i++){
            ledband = values[i];
            sleep(200);
        }
    }
}

#endif