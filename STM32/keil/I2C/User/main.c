/*
 * @Author: error: git config user.name && git config user.email & please set dead value or install git
 * @Date: 2022-11-04 14:27:51
 * @LastEditors: error: git config user.name && git config user.email & please set dead value or install git
 * @LastEditTime: 2022-11-04 22:46:36
 * @FilePath: \LED\User\main.c
 * @Description: 这是默认设置,请设置`customMade`, 打开koroFileHeader查看配置 进行设置: https://github.com/OBKoro1/koro1FileHeader/wiki/%E9%85%8D%E7%BD%AE
 */
#include "stm32f10x.h"                  // Device header
#include "bsp_i2c.h"
#include "bsp_led.h"
#include "bsp_delay.h"
#include "bsp_usart.h"

int main(void)
{
	uint8_t array[10]={0,1,2,3,4,5,6,7,8};
	I2C_Config();
	USART1_Config();
	LED_Config();
    USART_SendString(DEBUG_USARTX,"Start");

	EEPROM_page_Write(8,array,8);

	while (1)
	{
		LED_TURN(GPIO_Pin_1);
		Delay_ms(500);
	}
}
