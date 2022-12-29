/*
 * @Author: error: git config user.name && git config user.email & please set dead value or install git
 * @Date: 2022-11-04 14:27:51
 * @LastEditors: error: git config user.name && git config user.email & please set dead value or install git
 * @LastEditTime: 2022-11-04 20:37:01
 * @FilePath: \LED\User\main.c
 * @Description: 这是默认设置,请设置`customMade`, 打开koroFileHeader查看配置 进行设置: https://github.com/OBKoro1/koro1FileHeader/wiki/%E9%85%8D%E7%BD%AE
 */
#include "stm32f10x.h"                  // Device header
#include "bsp_delay.h"
#include "bsp_led.h"

int main(void)
{
	LED_Config();
	while (1)
	{
		LED_Reverse(GPIO_Pin_10);
		Delay_ms(500);
	}
}
