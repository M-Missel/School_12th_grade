#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <cstdint>

int main()
{
    PortOut seg7display(PortC, MASK);
    DigitalIn button(PA_6);

    DigitalOut seg7_ones_onoff(PC_11, 1);
    
    const uint8_t seg7values[]={
        0x3F,
        0x06,
        0x5B,
        0x4F,
        0x66,
        0x6D,
        0x7D,
        0x07, 
        0x7F,
        0x67
    };

    int i = 0;

    while (1) {
        seg7display.write(seg7values[i]);
        i++;
        i = i % 10;
        sleep(1000);
    }
}

#endif