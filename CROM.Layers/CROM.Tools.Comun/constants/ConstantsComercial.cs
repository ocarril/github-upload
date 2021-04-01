﻿namespace CROM.Tools.Comun.constants
{
    public static class ConstantsComercial
    {

        // TIPOS DE IMPUESTOS 
        public const string SUNAT_IMPU_IGV = "001";
        public const string SUNAT_IMPU_DSCTO = "002";
        public const string SUNAT_IMPU_IVARROZ_PILADO = "003";
        public const string SUNAT_IMPU_ISC = "004";
        public const string SUNAT_IMPU_EXPORTACION = "005";
        public const string SUNAT_IMPU_GRATUITO = "006";
        public const string SUNAT_IMPU_EXONERADO = "007";
        public const string SUNAT_IMPU_INAFECTO = "008";
        public const string SUNAT_IMPU_OTROS_TRIBUTOS = "009";

        public const string SUNAT_TipoDocumento_FACTURA = "01";
        public const string SUNAT_TipoDocumento_BOLETA_VENTA = "03";
        public const string SUNAT_TipoDocumento_BOLETA_TRANSPORTE = "06";
        public const string SUNAT_TipoDocumento_NOTA_CREDITO = "07";
        public const string SUNAT_TipoDocumento_NOTA_DEBITO = "08";
        public const string SUNAT_TipoDocumento_GUIA_REMISION = "09";
        public const string SUNAT_TipoDocumento_TICKET_MAQ_REGIST = "12";
        public const string SUNAT_TipoDocumento_RECIBO_SERV_PUBLICOS = "14";
        public const string SUNAT_TipoDocumento_BOLETO_SERV_TRANSP_URB = "15";
        public const string SUNAT_TipoDocumento_BOLETO_SERV_TRANSP_INTERPROV = "16";
        public const string SUNAT_TipoDocumento_COMPROBANTE_RETENCION = "20";
        public const string SUNAT_TipoDocumento_GUIA_REMISION_TRANSPORTISTA = "31";
        public const string SUNAT_TipoDocumento_SOLICITUD_BAJA = "99";

        public const string SUNAT_TipoDocumento_IDENTIDAD_SIN_RUC = "0";
        public const string SUNAT_TipoDocumento_IDENTIDAD_DNI = "1";
        public const string SUNAT_TipoDocumento_IDENTIDAD_CE = "4";
        public const string SUNAT_TipoDocumento_IDENTIDAD_RUC= "6";
        public const string SUNAT_TipoDocumento_IDENTIDAD_PASAPORTE = "7";
        public const string SUNAT_TipoDocumento_IDENTIDAD_CDI = "A";

        public const string SUNAT_ModalidadTransporte_PUBLICO = "01";
        public const string SUNAT_ModalidadTransporte_PRIVADO = "02";

        public const string SUNAT_FOLDER_BARRAS= "BARRAS";
        public const string SUNAT_FOLDER_DATA = "DATA";
        public const string SUNAT_FOLDER_FIRMA = "FIRMA";
        public const string SUNAT_FOLDER_REPO = "REPO";
        public const string SUNAT_FOLDER_REPOPDF = "PDF";
        public const string SUNAT_FOLDER_RPTA = "RPTA";
        public const string SUNAT_FOLDER_ENVIO = "ENVIO";
        public const string SUNAT_FOLDER_BAJA = "BAJA";

        public const string SUNAT_NIVEL_GLOBAL = "Global";
        public const string SUNAT_NIVEL_ITEM = "Item";

        public const int COMERCIAL_VENTA_CONTADO = 1;
        public const int COMERCIAL_VENTA_CREDITO = 2;
        public const int COMERCIAL_COMPRA_CONTADO = 3;
        public const int COMERCIAL_COMPRA_CREDITO = 4;

        public const string SUNAT_FILE_CAB_FCT_BLT = ".CAB";
        public const string SUNAT_FILE_CAB_NCR_NDB = ".NOT";
        public const string SUNAT_FILE_TRIBUTO = ".TRI";
        public const string SUNAT_FILE_LEYENDA = ".LEY";
        public const string SUNAT_FILE_DOC_REL = ".REL";
        public const string SUNAT_FILE_ADICIONAL = ".ACA";
        public const string SUNAT_FILE_PAGO = ".PAG";
        public const string SUNAT_FILE_PAGDETA = ".DPA";
        public const string SUNAT_FILE_BAJA_CBA = ".CBA";

    }
}
