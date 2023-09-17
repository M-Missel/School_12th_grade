#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"

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