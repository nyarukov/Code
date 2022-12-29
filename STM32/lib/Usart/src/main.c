#include "stm32f10x.h" // Device header
#include "Delay.h"
// #include "bsp_exti.h"
#include "bsp_led.h"
// #include "bsp_systick.h"
// #include "bsp_systick.h"
#include "bsp_usart.h"

#define SET         1
#define RESET       0 

#if 0
void USART1_IRQHandler(){
	uint16_t tmpe;
	
	if(USART_GetITStatus(DEBUG_USARTX,USART_IT_RXNE)!=RESET)
	{
		tmpe=USART_ReceiveData(DEBUG_USARTX);
		USART_SendData(DEBUG_USARTX,tmpe);
	}
}
#endif

int main(void)
{
	uint16_t tmpe;
	LED_Config();
	USART1_Config();
#if 0
        OLED_Init();
		EXIT_Config();
        OLED_ShowString(1,6,"ANum");
        OLED_ShowString(2,6,"BNum");
#endif
	USART_SendByte(DEBUG_USARTX, 'A');
	// USART_SendHalfWord(DEBUG_USARTX,1245);
	// uint32_t Array[]={'A','B','C','D','E','F','G'};
	// USART_SendArray(DEBUG_USARTX,Array,7);
	// char *str ="YUSAKA";
	// USART_SendString(DEBUG_USARTX,&str);

	while (1)
	{
		tmpe = USART_ReceiveData(DEBUG_USARTX);
#if 1
		switch (tmpe)
		{
		case 'R':
			LED_ON(GPIO_Pin_10);
			break;
		case 'G':
			LED_ON(GPIO_Pin_11);
			break;
		case 'B':
			LED_ON(GPIO_Pin_1);
			break;
		case '1':
			LED_OFF(GPIO_Pin_10);
			break;
		case '2':
			LED_OFF(GPIO_Pin_11);
			break;
		case '3':
			LED_OFF(GPIO_Pin_1);
			break;
		default:
			break;
		}
#endif

		// LED_ON(GPIO_Pin_11);
		// SysTick_Delay_ms(500);
		// LED_OFF(GPIO_Pin_11);
		// SysTick_Delay_ms(500);
	}
}
