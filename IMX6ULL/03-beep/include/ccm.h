#ifndef __CCM_H
#define __CCM_H

#include "imx6ull.h"

typedef struct{
    _IO CCR;
    _IO CCDR;
    _IO CSR;
    _IO CCSR;
    _IO CACRR;
    _IO CBCDR;
    _IO CBCMR;
    _IO CSCMR1;
    _IO CSCMR2;
    _IO CSCDR1;
    _IO CS1CDR;
    _IO CS2CDR;
    _IO CDCDR;
    _IO CHSCCDR;
    _IO CSCDR2;
    _IO CSCDR3;
        uint8_t RESERVED_0[8];
    _IO CDHIPR;
        uint8_t RESERVED_1[8];
    _IO CLPCR;
    _IO CISR;
    _IO CIMR;
    _IO CCOSR;
    _IO CGPR;
    _IO CCGRO;
    _IO CCGR1;
    _IO CCGR2;
    _IO CCGR3;
    _IO CCGR4;
    _IO CCGR5;
    _IO CCGR6;
        uint8_t RESERVED_2[4];
    _IO CMEOR;
}CCM_Type;

#define CCM ((CCM_Type *)CCM_BASE)       

#endif // !__CCM_H