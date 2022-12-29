#include "stm32f10x.h" // Device header
#include "Delay.h"
#include "bsp_usart.h"
#include "bsp_i2c.h"

int main(void)
{
	USART1_Config();
	I2C_Config();
	
	USART_SendString(DEBUG_USARTX, "start\n");
	Delay_ms(100);
	EEPROM_Byte_Write(11, 0x50);
	Delay_ms(100);
	USART_SendString(DEBUG_USARTX, "Write OK\n");

	while (1)
	-
		
	}
}
