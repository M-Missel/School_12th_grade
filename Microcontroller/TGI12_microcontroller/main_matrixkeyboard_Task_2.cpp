#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"

DigitalOut led(PC_0);
DigitalIn button(PC_3);

int main()
{
    button.mode(PullUp);
    BLINKING_OFF;
    sleep(500);
    while (1) {
        led = (button == 1) ? 1 : 0;
        sleep(50);
    }
}

#endif