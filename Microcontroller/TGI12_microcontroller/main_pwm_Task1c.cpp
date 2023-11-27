#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
PwmOut led6(PC_6);
PwmOut led7(PC_7);

int main()
{
    double value = 1/3;
    led6.period_ms(1);
    led7.period_us(666);
    

    while (1) {
        led6.write(0.3);
        led7.write(value);

        sleep(10);
    }
}

#endif