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
    while (1) {
        uint8_t running_lights = 0b00000001;
        uint8_t output;
        for(int i = 0; i < 7; i++){
            output = running_lights -1;
            ledband.write(output);
            running_lights = running_lights << 1;
            sleep(200);
        }
    }
}

#endif