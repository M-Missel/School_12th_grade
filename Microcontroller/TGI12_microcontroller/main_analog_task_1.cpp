
#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <cmath>
#include <cstdint>
#include <cstdio>

AnalogIn ain(PA_0, 0);

int main()
{
    double rawValue = 0, roundedRawValue, voltage;
    uint16_t u16_value = 0;

    while (1) {
        rawValue = ain.read();
        u16_value = ain.read_u16();

        printf("rawValue: %3.3f%% \n", rawValue);
        printf("percentage: %3.3f%% \n", rawValue * 100.0f);

        printf("normalized hex: 0x%04X \n", u16_value);
        printf("normalized hex: 0d%d \n", u16_value);

        voltage = 3.3 * rawValue;
        printf("Voltage U=%3.3f V \n", voltage);

        roundedRawValue = floor(rawValue * 1000);
        roundedRawValue = roundedRawValue / 1000;
        printf("rawValue rounded = %5.3f \n", roundedRawValue);
        sleep(4s);
    }
}

#endif