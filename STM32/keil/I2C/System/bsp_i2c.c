/*
 * @Author: error: git config user.name && git config user.email & please set dead value or install git
 * @Date: 2022-11-04 20:38:30
 * @LastEditors: error: git config user.name && git config user.email & please set dead value or install git
 * @LastEditTime: 2022-11-04 21:19:29
 * @FilePath: \I2C\System\bsp_i2c.c
 * @Description: 这是默认设置,请设置`customMade`, 打开koroFileHeader查看配置 进行设置: https://github.com/OBKoro1/koro1FileHeader/wiki/%E9%85%8D%E7%BD%AE
 */
#include "bsp_i2c.h"

void I2C_Config(void)
{
    I2C_InitTypeDef I2C_InitStruct;
    GPIO_InitTypeDef GPIO_InitStruct;
    RCC_APB1PeriphClockCmd(RCC_APB1Periph_I2C1, ENABLE);
    RCC_APB2PeriphClockCmd(RCC_APB2Periph_GPIOB, ENABLE);

    GPIO_InitStruct.GPIO_Pin = GPIO_Pin_6 | GPIO_Pin_7; // 6-SCL,7-SDA
    GPIO_InitStruct.GPIO_Mode = GPIO_Mode_AF_OD;
    GPIO_InitStruct.GPIO_Speed = GPIO_Speed_50MHz;
    GPIO_Init(GPIOB, &GPIO_InitStruct);

    I2C_InitStruct.I2C_Ack = I2C_Ack_Enable;
    I2C_InitStruct.I2C_AcknowledgedAddress = I2C_AcknowledgedAddress_7bit;
    I2C_InitStruct.I2C_ClockSpeed = 400000;
    I2C_InitStruct.I2C_DutyCycle = I2C_DutyCycle_2;
    I2C_InitStruct.I2C_Mode = I2C_Mode_I2C;
    I2C_InitStruct.I2C_OwnAddress1 = 0x7f;
    I2C_Init(I2C1, &I2C_InitStruct);

    I2C_Cmd(I2C1, ENABLE);
}
void EEPROM_Byte_Write(uint8_t addr, uint8_t date)
{
    I2C_GenerateSTART(I2C1, ENABLE);
    while (I2C_CheckEvent(I2C1, I2C_EVENT_MASTER_MODE_SELECT) == ERROR);
    I2C_Send7bitAddress(I2C1, 0xA0, I2C_Direction_Transmitter);
    while (I2C_CheckEvent(I2C1, I2C_EVENT_MASTER_TRANSMITTER_MODE_SELECTED) == ERROR);
    I2C_SendData(I2C1, addr);
    while (I2C_CheckEvent(I2C1, I2C_EVENT_MASTER_BYTE_TRANSMITTING) == ERROR);
    I2C_SendData(I2C1, date);
    while (I2C_CheckEvent(I2C1, I2C_EVENT_MASTER_BYTE_TRANSMITTED) == ERROR);
    I2C_GenerateSTOP(I2C1, ENABLE);
    USART_SendString(DEBUG_USARTX, "Transfer Success\n");
}
void EEPROM_page_Write(uint8_t addr, uint8_t *date,uint8_t numlen)
{
    I2C_GenerateSTART(I2C1,ENABLE);
    while(I2C_CheckEvent(I2C1,I2C_EVENT_MASTER_MODE_SELECT)!=SUCCESS);
    I2C_Send7bitAddress(I2C1,0xA0,I2C_Direction_Transmitter);
    while(I2C_CheckEvent(I2C1,I2C_EVENT_MASTER_TRANSMITTER_MODE_SELECTED)!=SUCCESS);
    I2C_SendData(I2C1,addr);
    while(I2C_CheckEvent(I2C1,I2C_EVENT_MASTER_BYTE_TRANSMITTING)!=SUCCESS);
    while(numlen--)
    {
        I2C_SendData(I2C1,*date);
        while(I2C_CheckEvent(I2C1,I2C_EVENT_MASTER_BYTE_TRANSMITTED)!=SUCCESS);
        *date++;
    }
    I2C_GenerateSTOP(I2C1,ENABLE);
    USART_SendString(DEBUG_USARTX, "Transfer Success\n");
}
