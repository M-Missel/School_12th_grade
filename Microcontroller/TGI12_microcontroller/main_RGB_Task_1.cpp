#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"

int main()
{
    DigitalOut red(PC_0);
    DigitalOut green(PC_1);
    DigitalOut blue(PC_2);
    while (1) {
        blue = 0;
        red = 1;
        sleep(500);
        red = 0;
        green = 1;
        sleep(500);
        green = 0;
        blue = 1;
        sleep(500);
    }
}

#endif