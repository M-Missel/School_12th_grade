#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */
#include "mbed.h"
#include <string>

// Blinking rate in milliseconds
#define BLINKING_RATE 3000ms
#define BLINKING_TRUE true
#define sleep ThisThread::sleep_for

int main() {
  BufferedSerial test(USBTX, USBRX);
  DigitalOut led1(LED1);

  char buffer[20] = {0};
  test.set_baud(9600);
  test.set_format(8, BufferedSerial::None, 1);

  string cmd = "";

  while (true) {
    if (test.readable()) {
      int num = test.read(buffer, 1);
      cmd = buffer;
    }

    if (cmd == "on") {
      led1 = 1;
    } else if (cmd == "off") {
      led1 = 0;
    }
  }
}
#endif