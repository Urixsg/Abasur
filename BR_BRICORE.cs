/*        
V1.0 - ALEX - 140821 - ValidaMultiplos
			 			Valida en la Tx de pedidos, cotizaciones y Froid para que al momento de 
				 		capturar la venta sean un minimo de venta en N multiplos
V1.0 - URIX - BuscaProductosXCB
		      Busca producto, descripción, fracc x unidad del producto con base en el código de barras escaneado

V1.0 - URIX - GeneraEtiqueta  
			  Genera el codigo de barras del cliente siempre y cuando tenga existencia x UDN x Almacén
V1.1 - ALEX - GeneraEtiqueta
			  Se agrego el parametro Tipo y el Rol 
			  	Tipo = 0 - Recepción de Mercancia
				Tipo = 1 - PICKING 
			  	Rol = Descripción del CB
			  
V1.0 - LIZ - 170821 - GeneraExistenciaACombo 
						Si en los pedidos hay productos con productos agruapación
						inserta existencia a productos agrupados para que no mande error el despacho
						de que "el producto agrupado no tiene existencia"
						
V1.0 - URIX - 121021 - GeneraTicketLS - Reporte Ticket de LS para surtir						
V1.1 - ALEX - 291021 - GeneraTicketLS - Reporte Ticket de LS para surtir
V1.2 - URIX - 231021 - GeneraTicketLS - Se anexa traspasos 
											
V1.0 - URIX - 131021 - DatosEmbarque - Obtiene campos calculados del embarque FRBRR_FAC_DOCUMENTO Y FRBRRLIQ_LIDAEMBARQUE
						
V1.0 - URIX - 141021 - ConsultaEmbarque - SQL de embarques abiertos
V1.1 - URIX - 231221 - ConsultaEmbarque - Se anexa consulta de traspasos				

						
V1.0 - URIX - 111121 - DesapartaPedidoAbasur - Al verificar remisiones permite desapartar CanEnt y volver a apartar
						
V1.0 - URIX - 111121 - NCProntoPago - Calcula las NC de pronto pago en la liquidación /Acción de la liq.

V1.0 - ALEX - 171121 - DatosLiqEmbarque - Reporte de Embarque LIQ_LIQUIDACIONEMBARQUE, LIQ_LIQUIDACIONEMBARQUEDET

V1.0 - URIX - 181121 - CancelaFactura - Cancela la factura y crea entrada de ruta en la liq. en cuestión/Acción de la liq.

V1.0 - ALEX - 301221 - CreaHojaTraspasos - Reporte de Salida de Traspasos

V1.0 - ALEX - 070122 - CreaPaseDeSalida - Reporte Pase de Salida

V1.0 - URIX - 100122 - Divide los traspasos en 500 kg

V1.0 - URIX - 170122 - ParticionaPedido - Particiona un pedido en pedidos de 2mil pesos
V1.1 - URIX - 140122 - ParticionaPedido - Se divide en estado 65(Verificado) previo a la facturación en FR_TABPED_FACTURA
V1.2 - URIX - 250122 - ParticionaPedido - Se parametriza por cliente CTE_CLIENTE.BRCTE_PARTPED

V1.0 - ALEX - 250122 - EnviaDocumentosPDF - Envia OC y Cotizaciones por  correo en PDF

*/
