/*
 * @Author: error: git config user.name && git config user.email & please set dead value or install git
 * @Date: 2022-11-04 20:38:30
 * @LastEditors: error: git config user.name && git config user.email & please set dead value or install git
 * @LastEditTime: 2022-11-04 21:40:16
 * @FilePath: \I2C\System\bsp_i2c.h
 * @Description: 这是默认设置,请设置`customMade`, 打开koroFileHeader查看配置 进行设置: https://github.com/OBKoro1/koro1FileHeader/wiki/%E9%85%8D%E7%BD%AE
 */
#ifndef __BSP_I2C_H
#define __BSP_I2C_H

#include "stm32f10x.h"
#include "bsp_usart.h"

void I2C_Config(void);
void EEPROM_Byte_Write(uint8_t addr,uint8_t date);
void EEPROM_page_Write(uint8_t addr, uint8_t *date,uint8_t numlen);

#endif // !__BSP_I2C_H
