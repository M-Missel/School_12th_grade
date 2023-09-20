#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"

int main()
{
    BusOut output(PC_0, PC_1, PC_2);

    output = 0b001;
    while (1) {
        output = output << 1;

        if(output == 0b100)
            output = 0b001;

        sleep(500);
    }
}

#endif