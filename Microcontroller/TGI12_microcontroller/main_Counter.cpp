#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"

int main()
{
    DigitalOut led(LED1);
    BufferedSerial serial_port(USBTX, USBRX);

    while (1) {
        for(int i = 0; i <= 10; i++){
            printf("Durchgang %u \n", i);
            sleep(SLEEP_RATE);
        }
    }
}

#endif