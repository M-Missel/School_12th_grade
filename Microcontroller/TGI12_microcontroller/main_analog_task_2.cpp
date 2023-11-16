#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <cmath>
#include <cstdint>
#include <cstdio>

AnalogIn ain(PA_0);
DigitalOut led(PC_3, 1);

int main()
{
    double rawValue = 0, voltage;

    while (1) {
        rawValue = ain.read();

        voltage = 3.3 * rawValue;

        voltage >= 1.65 ? BLINKING_ON_MFS : BLINKING_OFF_MFS;
    }
}

#endif