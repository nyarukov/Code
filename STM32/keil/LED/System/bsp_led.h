/*
 * @Author: error: git config user.name && git config user.email & please set dead value or install git
 * @Date: 2022-11-04 20:11:23
 * @LastEditors: error: git config user.name && git config user.email & please set dead value or install git
 * @LastEditTime: 2022-11-04 20:27:54
 * @FilePath: \LED\System\bps_led.h
 * @Description: 这是默认设置,请设置`customMade`, 打开koroFileHeader查看配置 进行设置: https://github.com/OBKoro1/koro1FileHeader/wiki/%E9%85%8D%E7%BD%AE
 */
#ifndef __BSP_LED_H
#define __BSP_LED_H

#include "stm32f10x.h"

#define DEBUG_LED_CLK   RCC_APB2PeriphClockCmd
#define DEBUG_LED_PCK   RCC_APB2Periph_GPIOB
#define DEBUG_LED_PROT  GPIOB

#define DEBUG_LED_PIN   GPIO_Pin_1 |GPIO_Pin_10 | GPIO_Pin_11
#define DEBUG_LED_MODE  GPIO_Mode_Out_PP
#define DEBUG_LED_SPEED GPIO_Speed_50MHz

void LED_Config(void);
void LED_ON(uint16_t GPIO_Pin);
void LED_OFF(uint16_t GPIO_Pin);
void LED_Reverse(uint16_t GPIO_Pin);

#endif

