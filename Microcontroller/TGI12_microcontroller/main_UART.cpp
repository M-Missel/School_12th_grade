#if 1
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <string>

// Blinking rate in milliseconds
#define BLINKING_RATE     3000ms
#define BLINKING_TRUE     true
#define sleep             ThisThread::sleep_for

BufferedSerial pc(USBTX, USBRX, 9600);
BufferedSerial blue(PB_10, PB_11, 9600);
DigitalOut enable(PB_12);

Thread thread_pc;
Thread thread_blue;

void initSerial(){
    pc.set_format(8, BufferedSerial::None, 1);
    blue.set_format(8, BufferedSerial::None, 1);
    enable.write(1);
}

void pc_con_thread(){
    char buffer[40] = {0};
    int num;
    string cmd = "";

    while(true){
        if(blue.readable()){
            num = blue.read(buffer, sizeof(buffer));
            cmd = buffer;
        }
    }
}


int main()
{
    char buffer[40] = {0};

    initSerial();
}
#endif