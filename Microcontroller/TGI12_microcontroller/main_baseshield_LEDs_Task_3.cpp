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
        for(int i = 0; i < 7; i++){
            ledband.write(running_lights);
            running_lights = running_lights << 1;
            sleep(500);
        }
    }
}

#endif