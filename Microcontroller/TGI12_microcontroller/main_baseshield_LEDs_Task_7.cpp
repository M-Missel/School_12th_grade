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
        0b00000011,
        0b00000111,
        0b00001111,
        0b00011111,
        0b00111111,
        0b01111111,
        0b11111111
    };

    while (1) {
        for(int i = 0; i < end(values) - begin(values); i++){
            ledband = values[i];
            sleep(200);
        }
    }
}

#endif