#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <cmath>
#include <cstdint>
#include <cstdio>

#define PORTMASK 0xFF

AnalogIn ain(PA_0);
PortOut leds(PortC, PORTMASK);

uint8_t dataLed[] = {
    0x1,
    0x3, 
    0x7,
    0xF,
    0x1F,
    0x3F,
    0x7F,
    0xFF
};

int main()
{
    double rawValue = 0, voltage;


    while (1) {
        rawValue = ain.read();

        voltage = (3.3 * rawValue);

        if(voltage <= (3.3 * 1/8))
            leds.write(dataLed[0]);
        else if (voltage <= (3.3 * 2/8) && voltage >= (3.3 * 1/8))
            leds.write(dataLed[1]);
        else if (voltage <= (3.3 * 3/8) && voltage >= (3.3 * 2/8))
            leds.write(dataLed[2]);
        else if (voltage <= (3.3 * 4/8) && voltage >= (3.3 * 3/8))
            leds.write(dataLed[3]);
        else if (voltage <= (3.3 * 5/8) && voltage >= (3.3 * 4/8))
            leds.write(dataLed[4]);
        else if (voltage <= (3.3 * 6/8) && voltage >= (3.3 * 5/8))
            leds.write(dataLed[5]);
        else if (voltage <= (3.3 * 7/8) && voltage >= (3.3 * 8/8))
            leds.write(dataLed[6]);
        else if (voltage <= 3.3 && voltage >= (3.3 * 7/8))
            leds.write(dataLed[7]);
    }
}

#endif