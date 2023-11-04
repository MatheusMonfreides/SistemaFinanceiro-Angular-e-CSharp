import { BaseEntity } from "./BaseEntity";

export class ReceitaXinvestimento extends BaseEntity
{
    RXI_IDUSUARIO: string;
    RXI_IDRECEITA:string;
    RXI_DATADEVENDA:Date;
    RXI_DATADEVENDA:Date;

    NomePropriedade:string="";
    mensagem:string="";
    notificacoes:[];
}