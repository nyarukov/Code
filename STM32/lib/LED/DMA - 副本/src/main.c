#include "stm32f10x.h" // Device header
#include "Delay.h"
// #include "bsp_exti.h"
#include "bsp_led.h"
// #include "bsp_systick.h"
// #include "bsp_systick.h"
#include "bsp_usart.h"
#include "bsp_dma_mtm.h"

#define SET 1
#define RESET 0

extern const uint32_t aSRC_Const_Buffer[BUFFER_SIZE];
extern uint32_t aDST_Buffer[BUFFER_SIZE];
uint32_t a[10]={0,1,2,3,4,5,6,7,8,9};

int main(void)
{
	USART1_Config();
	MtM_DMA_Config();

	USART_SendString(DEBUG_USARTX, "Config_OK\n");
	USART_SendString(DEBUG_USARTX, "StartCmp\n");
	
	while (DMA_GetFlagStatus(DMA1_FLAG_TC1) == RESET);
	if (BufferData_Cmp(aSRC_Const_Buffer, aDST_Buffer, BUFFER_SIZE) != 0)
	{
		USART_SendString(DEBUG_USARTX, "Data_OK\n");
		Delay_ms(1000);
		USART_SendArray(DEBUG_USARTX,a,BUFFER_SIZE);
	}
	else
	{

		USART_SendString(DEBUG_USARTX, "Data_Error\n");
	}
	while (1)
	{
		
	}
}
