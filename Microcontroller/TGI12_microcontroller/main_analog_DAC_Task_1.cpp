#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"

AnalogOut aout(PA_4);
AnalogOut led(LED1);

int main()
{
    float voltageValue;
    while (1) {
        for(int i = 0; i < 100; i++){
            voltageValue = (float)i/100;
            aout.write(voltageValue);
            led.write(voltageValue);
            sleep(50);
        }
    }
}

#endif