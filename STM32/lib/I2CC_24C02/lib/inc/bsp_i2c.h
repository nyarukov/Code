#ifndef __BSP_I2C_H
#define __BSP_I2C_H

#include "stm32f10x.h"
#include "bsp_usart.h"

void I2C_Config(void);
void EEPROM_Byte_Write(uint8_t addr,uint8_t date);
void EEPROM_pages_Write(uint8_t addr, uint8_t *date,uint8_t numlen);
#endif // !__BSP_I2C_H