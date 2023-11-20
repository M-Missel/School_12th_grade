#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <numbers>
#include <cmath>

# define M_PI           3.14159265358979323846

AnalogOut aout(PA_4);

int main(){
    float amplitudeValue = 1.0, frequenzy = 10.0, deltaPeriod;
    int countPoints = 100;


    while(1){
        for(int i = 0; i < countPoints; i++){
            aout = 0.5 + sin(2 * M_PI * (1 / frequenzy));
        }
    }
}

#endif