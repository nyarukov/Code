/*
 * @Author: error: git config user.name && git config user.email & please set dead value or install git
 * @Date: 2022-11-04 20:37:57
 * @LastEditors: error: git config user.name && git config user.email & please set dead value or install git
 * @LastEditTime: 2022-11-04 21:26:04
 * @FilePath: \I2C\System\bsp_led.h
 * @Description: 这是默认设置,请设置`customMade`, 打开koroFileHeader查看配置 进行设置: https://github.com/OBKoro1/koro1FileHeader/wiki/%E9%85%8D%E7%BD%AE
 */
#ifndef __BSP_LED_H
#define __BSP_LED_H

#include "stm32f10x.h"

#define DEBUG_GPIO_Mode            GPIO_Mode_Out_PP
#define DEBUG_GPIO_Pin             GPIO_Pin_1 | GPIO_Pin_10 | GPIO_Pin_11 
#define DEBUG_GPIO_Speed           GPIO_Speed_50MHz
#define DEBUG_GPIO_Cmd             RCC_APB2PeriphClockCmd
#define DEBUG_GPIO_CLK             RCC_APB2Periph_GPIOB
#define DEBUG_GPIO_Port            GPIOB

void LED_Config(void);
void LED_ON(uint16_t GPIO_Pin);
void LED_OFF(uint16_t GPIO_Pin);
void LED_TURN(uint16_t GPIO_Pin);

#endif // !__BSP_LED_H
