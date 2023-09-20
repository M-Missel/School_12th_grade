#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
DigitalOut led0(PC_0, 0);
DigitalOut led1(PC_1, 0);
DigitalOut led2(PC_2, 0);
DigitalOut led3(PC_3, 0);
DigitalOut led4(PC_4, 0);
DigitalOut led5(PC_5, 0);
DigitalOut led6(PC_6, 0);
DigitalOut led7(PC_7, 0);

DigitalOut running_light[] = {led0, led1, led2, led3, led4, led5, led6, led7};

int main()
{
    while (1) {
        for(int i = 0; i < end(running_light) - begin(running_light); i++){
            running_light[i] != running_light[i]; 
            sleep(500);
            running_light[i] != running_light[i];
        }
    }
}

#endif