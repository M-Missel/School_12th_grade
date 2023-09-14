#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
// Blinking rate in milliseconds
#define BLINKING_RATE       500ms
#define BLINKING_ON         led = 1
#define BLINKING_OFF        led = 0
#define BUTTON_PRESSED      button == 0
#define sleep               ThisThread::sleep_for

int main()
{
    // Initialise the digital pin LED1 as an output
    DigitalOut led(LED1);
    DigitalIn button(BUTTON1);

    while (1) {
      if (BUTTON_PRESSED) {
        BLINKING_ON;
      } else {
        BLINKING_OFF;
      }
    }
}

#endif