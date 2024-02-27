using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace sigestel.Models;

public partial class MaxDbContext : DbContext
{
    public MaxDbContext()
    {
    }

    public MaxDbContext(DbContextOptions<MaxDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AcuerdosMarcoVirtuales> AcuerdosMarcoVirtuales { get; set; }

    public virtual DbSet<AcuerdosTarificacion> AcuerdosTarificacion { get; set; }

    public virtual DbSet<Agrupado700000> Agrupado700000 { get; set; }

    public virtual DbSet<Agrupado901000DetC1> Agrupado901000DetC1 { get; set; }

    public virtual DbSet<CamposExportacion> CamposExportacion { get; set; }

    public virtual DbSet<CfDatosActivos> CfDatosActivos { get; set; }

    public virtual DbSet<CfDetCobrointernas> CfDetCobrointernas { get; set; }

    public virtual DbSet<CfDetmvCobrointernas> CfDetmvCobrointernas { get; set; }

    public virtual DbSet<CfPerfilConsumo> CfPerfilConsumo { get; set; }

    public virtual DbSet<CfResCfactura> CfResCfactura { get; set; }

    public virtual DbSet<CfResConsumo> CfResConsumo { get; set; }

    public virtual DbSet<CfResConsumodatos> CfResConsumodatos { get; set; }

    public virtual DbSet<CfResConsumominimo> CfResConsumominimo { get; set; }

    public virtual DbSet<CfResmvConsumodatos> CfResmvConsumodatos { get; set; }

    public virtual DbSet<CfResumenTelf> CfResumenTelf { get; set; }

    public virtual DbSet<ComparativoAcuerdos> ComparativoAcuerdos { get; set; }

    public virtual DbSet<Conceptos> Conceptos { get; set; }

    public virtual DbSet<ConceptosAgrupacion> ConceptosAgrupacion { get; set; }

    public virtual DbSet<ConceptosFacturables> ConceptosFacturables { get; set; }

    public virtual DbSet<CondicionesAcuerdosMarco> CondicionesAcuerdosMarco { get; set; }

    public virtual DbSet<ConsumoResponsableEmpleado> ConsumoResponsableEmpleado { get; set; }

    public virtual DbSet<ConsumoTipoTraficoPorEmpleado> ConsumoTipoTraficoPorEmpleado { get; set; }

    public virtual DbSet<DetalleInventarioLineas702010DetC2> DetalleInventarioLineas702010DetC2 { get; set; }

    public virtual DbSet<DetalleLlamadasMovistar> DetalleLlamadasMovistar { get; set; }

    public virtual DbSet<DimConcepto> DimConcepto { get; set; }

    public virtual DbSet<DimConceptoFactura> DimConceptoFactura { get; set; }

    public virtual DbSet<DimDestino> DimDestino { get; set; }

    public virtual DbSet<DimFactura> DimFactura { get; set; }

    public virtual DbSet<DimFecha> DimFecha { get; set; }

    public virtual DbSet<DimGeografia> DimGeografia { get; set; }

    public virtual DbSet<DimLinea> DimLinea { get; set; }

    public virtual DbSet<DimOperador> DimOperador { get; set; }

    public virtual DbSet<DimTarifa> DimTarifa { get; set; }

    public virtual DbSet<DimTipoAmbito> DimTipoAmbito { get; set; }

    public virtual DbSet<DimTipoLlamada> DimTipoLlamada { get; set; }

    public virtual DbSet<DimTipoServicio> DimTipoServicio { get; set; }

    public virtual DbSet<DimTipoTrafico> DimTipoTrafico { get; set; }

    public virtual DbSet<DimTramosConsumo> DimTramosConsumo { get; set; }

    public virtual DbSet<DimUnidadMedida> DimUnidadMedida { get; set; }

    public virtual DbSet<DimUnidadesFuncional> DimUnidadesFuncional { get; set; }

    public virtual DbSet<DimUnidadesGestion> DimUnidadesGestion { get; set; }

    public virtual DbSet<Empresas> Empresas { get; set; }

    public virtual DbSet<EmpresasAnexo> EmpresasAnexo { get; set; }

    public virtual DbSet<EstablecimientoLlamadas> EstablecimientoLlamadas { get; set; }

    public virtual DbSet<FacturacionSigestelxCiclo> FacturacionSigestelxCiclo { get; set; }

    public virtual DbSet<FijaProyecto> FijaProyecto { get; set; }

    public virtual DbSet<GruposUsuarios> GruposUsuarios { get; set; }

    public virtual DbSet<ImportePorLineaDatos> ImportePorLineaDatos { get; set; }

    public virtual DbSet<InvarioVozTrafico> InvarioVozTrafico { get; set; }

    public virtual DbSet<InventarioLineas> InventarioLineas { get; set; }

    public virtual DbSet<InventarioLineas2> InventarioLineas2 { get; set; }

    public virtual DbSet<InventarioMovilCuotas> InventarioMovilCuotas { get; set; }

    public virtual DbSet<InventarioMovilVario> InventarioMovilVario { get; set; }

    public virtual DbSet<InventarioTerminales> InventarioTerminales { get; set; }

    public virtual DbSet<InventarioVozCuotasV2> InventarioVozCuotasV2 { get; set; }

    public virtual DbSet<InventarioVozcuotas> InventarioVozcuotas { get; set; }

    public virtual DbSet<Lineas> Lineas { get; set; }

    public virtual DbSet<LineasTelefonoCuotas> LineasTelefonoCuotas { get; set; }

    public virtual DbSet<LlamadasRdInteligente> LlamadasRdInteligente { get; set; }

    public virtual DbSet<MantCuotasCargos> MantCuotasCargos { get; set; }

    public virtual DbSet<MantDesPromoParametros> MantDesPromoParametros { get; set; }

    public virtual DbSet<MantDescPromo> MantDescPromo { get; set; }

    public virtual DbSet<MantMensaje> MantMensaje { get; set; }

    public virtual DbSet<Mes> Mes { get; set; }

    public virtual DbSet<MovilCosteporLinea> MovilCosteporLinea { get; set; }

    public virtual DbSet<MovilCuotasyVarios> MovilCuotasyVarios { get; set; }

    public virtual DbSet<MovilProyecto> MovilProyecto { get; set; }

    public virtual DbSet<MovilResumenTipoTrafico> MovilResumenTipoTrafico { get; set; }

    public virtual DbSet<MovilfechFactNum> MovilfechFactNum { get; set; }

    public virtual DbSet<MovistarDetalleLlamadas> MovistarDetalleLlamadas { get; set; }

    public virtual DbSet<NivelAsociacion> NivelAsociacion { get; set; }

    public virtual DbSet<NlineasCorpTotal> NlineasCorpTotal { get; set; }

    public virtual DbSet<NlineasMovil> NlineasMovil { get; set; }

    public virtual DbSet<NlineasVoz> NlineasVoz { get; set; }

    public virtual DbSet<NllamadasCorporativaImporte> NllamadasCorporativaImporte { get; set; }

    public virtual DbSet<NllamadasTotal> NllamadasTotal { get; set; }

    public virtual DbSet<Operador> Operador { get; set; }

    public virtual DbSet<Organigrama> Organigrama { get; set; }

    public virtual DbSet<Parametros> Parametros { get; set; }

    public virtual DbSet<Presupuestos> Presupuestos { get; set; }

    public virtual DbSet<ProvAlbaranes> ProvAlbaranes { get; set; }

    public virtual DbSet<ProvAtributos> ProvAtributos { get; set; }

    public virtual DbSet<ProvBaseCatalogo> ProvBaseCatalogo { get; set; }

    public virtual DbSet<ProvCatPrdconvergentes> ProvCatPrdconvergentes { get; set; }

    public virtual DbSet<ProvCatalogos> ProvCatalogos { get; set; }

    public virtual DbSet<ProvColectivos> ProvColectivos { get; set; }

    public virtual DbSet<ProvCompromisosLinea> ProvCompromisosLinea { get; set; }

    public virtual DbSet<ProvDocumentosCt> ProvDocumentosCt { get; set; }

    public virtual DbSet<ProvFicherosAdjuntos> ProvFicherosAdjuntos { get; set; }

    public virtual DbSet<ProvFiltrosBusqueda> ProvFiltrosBusqueda { get; set; }

    public virtual DbSet<ProvHistPeticiones> ProvHistPeticiones { get; set; }

    public virtual DbSet<ProvLineas> ProvLineas { get; set; }

    public virtual DbSet<ProvLineasAlb> ProvLineasAlb { get; set; }

    public virtual DbSet<ProvMargenHbd> ProvMargenHbd { get; set; }

    public virtual DbSet<ProvModosFinanciacionTerminales> ProvModosFinanciacionTerminales { get; set; }

    public virtual DbSet<ProvPeticionesIncidencias> ProvPeticionesIncidencias { get; set; }

    public virtual DbSet<ProvPrdconvergentesEncurso> ProvPrdconvergentesEncurso { get; set; }

    public virtual DbSet<ProvPuntosPromo1> ProvPuntosPromo1 { get; set; }

    public virtual DbSet<ProvRcatalogoTerminal> ProvRcatalogoTerminal { get; set; }

    public virtual DbSet<ProvReferentes> ProvReferentes { get; set; }

    public virtual DbSet<ProvRterminalTdatos> ProvRterminalTdatos { get; set; }

    public virtual DbSet<ProvTarifasDatos> ProvTarifasDatos { get; set; }

    public virtual DbSet<ProvTerminales> ProvTerminales { get; set; }

    public virtual DbSet<ProvTerminalesFinanciados> ProvTerminalesFinanciados { get; set; }

    public virtual DbSet<ProvTiposPeticiones> ProvTiposPeticiones { get; set; }

    public virtual DbSet<ProvTitulares> ProvTitulares { get; set; }

    public virtual DbSet<ProvUsuarios> ProvUsuarios { get; set; }

    public virtual DbSet<ProvVersionesApp> ProvVersionesApp { get; set; }

    public virtual DbSet<Proyectos> Proyectos { get; set; }

    public virtual DbSet<QryAltaSocios> QryAltaSocios { get; set; }

    public virtual DbSet<QryCiclosxEmpresaAgrupado> QryCiclosxEmpresaAgrupado { get; set; }

    public virtual DbSet<QryConstruirCatalogo> QryConstruirCatalogo { get; set; }

    public virtual DbSet<QryConsumoMinimo> QryConsumoMinimo { get; set; }

    public virtual DbSet<QryConsumoMre> QryConsumoMre { get; set; }

    public virtual DbSet<QryConsumoVozxLineayCiclo> QryConsumoVozxLineayCiclo { get; set; }

    public virtual DbSet<QryDireccionFacturacionClientes> QryDireccionFacturacionClientes { get; set; }

    public virtual DbSet<QryDireccionFacturacionUsuarios> QryDireccionFacturacionUsuarios { get; set; }

    public virtual DbSet<QryEmpresaAmpliada> QryEmpresaAmpliada { get; set; }

    public virtual DbSet<QryEnviosLineas> QryEnviosLineas { get; set; }

    public virtual DbSet<QryInfGestion> QryInfGestion { get; set; }

    public virtual DbSet<QryInfProvision> QryInfProvision { get; set; }

    public virtual DbSet<QryPagosFacturaColectivo> QryPagosFacturaColectivo { get; set; }

    public virtual DbSet<QryPrlaccLineas> QryPrlaccLineas { get; set; }

    public virtual DbSet<QryPrlaccLineasExt> QryPrlaccLineasExt { get; set; }

    public virtual DbSet<QryReparacionTerminales> QryReparacionTerminales { get; set; }

    public virtual DbSet<QryReparacionTerminalesExtend> QryReparacionTerminalesExtend { get; set; }

    public virtual DbSet<QryResumenFacturacion> QryResumenFacturacion { get; set; }

    public virtual DbSet<QryResumenFacturacionLineaConsumos> QryResumenFacturacionLineaConsumos { get; set; }

    public virtual DbSet<QryResumenFacturacionLineaCuotas> QryResumenFacturacionLineaCuotas { get; set; }

    public virtual DbSet<QryResumenFacturacionLineaDatos> QryResumenFacturacionLineaDatos { get; set; }

    public virtual DbSet<QryResumenLineasxCiclo> QryResumenLineasxCiclo { get; set; }

    public virtual DbSet<QryServiciosDatos> QryServiciosDatos { get; set; }

    public virtual DbSet<QryServiciosFax> QryServiciosFax { get; set; }

    public virtual DbSet<QryServiciosVodafoneFijo> QryServiciosVodafoneFijo { get; set; }

    public virtual DbSet<QryTarifasDatosUnicasxColectivo> QryTarifasDatosUnicasxColectivo { get; set; }

    public virtual DbSet<QryTerminalesnoPublicados> QryTerminalesnoPublicados { get; set; }

    public virtual DbSet<QryTmpResumenFacturacion> QryTmpResumenFacturacion { get; set; }

    public virtual DbSet<QryTmpResumenFacturacionCompleta> QryTmpResumenFacturacionCompleta { get; set; }

    public virtual DbSet<QryTmpResumenFacturacionLineaConsumos> QryTmpResumenFacturacionLineaConsumos { get; set; }

    public virtual DbSet<QryTmpResumenFacturacionLineaCuotas> QryTmpResumenFacturacionLineaCuotas { get; set; }

    public virtual DbSet<QryTmpResumenLineasxCiclo> QryTmpResumenLineasxCiclo { get; set; }

    public virtual DbSet<QryUltimaExtensionxColectivo> QryUltimaExtensionxColectivo { get; set; }

    public virtual DbSet<RelacionAcuerdos> RelacionAcuerdos { get; set; }

    public virtual DbSet<ResponsablesEmpleados> ResponsablesEmpleados { get; set; }

    public virtual DbSet<ResumenVozCuotasyConsumo> ResumenVozCuotasyConsumo { get; set; }

    public virtual DbSet<ScctPaises> ScctPaises { get; set; }

    public virtual DbSet<ScctZonas> ScctZonas { get; set; }

    public virtual DbSet<ScttPaisesZonas> ScttPaisesZonas { get; set; }

    public virtual DbSet<SimulacionesTarifacion> SimulacionesTarifacion { get; set; }

    public virtual DbSet<SistemaAuxTablasTh> SistemaAuxTablasTh { get; set; }

    public virtual DbSet<SistemaLogEjecucion> SistemaLogEjecucion { get; set; }

    public virtual DbSet<SutAbonos> SutAbonos { get; set; }

    public virtual DbSet<SutAccesosFallidos> SutAccesosFallidos { get; set; }

    public virtual DbSet<SutAdministradores> SutAdministradores { get; set; }

    public virtual DbSet<SutAgentes> SutAgentes { get; set; }

    public virtual DbSet<SutAsociacionesPerfilUsuario> SutAsociacionesPerfilUsuario { get; set; }

    public virtual DbSet<SutAtributosColectivo> SutAtributosColectivo { get; set; }

    public virtual DbSet<SutAtributosTemp> SutAtributosTemp { get; set; }

    public virtual DbSet<SutAutorizadosFibra> SutAutorizadosFibra { get; set; }

    public virtual DbSet<SutAveriasTerminal> SutAveriasTerminal { get; set; }

    public virtual DbSet<SutAvisos> SutAvisos { get; set; }

    public virtual DbSet<SutCambiosCuentaFacturacionPlanesPrecios> SutCambiosCuentaFacturacionPlanesPrecios { get; set; }

    public virtual DbSet<SutCatalogoServicios> SutCatalogoServicios { get; set; }

    public virtual DbSet<SutClientesUsuariosFacturas> SutClientesUsuariosFacturas { get; set; }

    public virtual DbSet<SutCompromisos> SutCompromisos { get; set; }

    public virtual DbSet<SutConfiguracion> SutConfiguracion { get; set; }

    public virtual DbSet<SutConstantes> SutConstantes { get; set; }

    public virtual DbSet<SutContactosVodafone> SutContactosVodafone { get; set; }

    public virtual DbSet<SutControlAcceso> SutControlAcceso { get; set; }

    public virtual DbSet<SutControlTerminales> SutControlTerminales { get; set; }

    public virtual DbSet<SutConversorIdadsl> SutConversorIdadsl { get; set; }

    public virtual DbSet<SutCuotasVodafone> SutCuotasVodafone { get; set; }

    public virtual DbSet<SutDescargas> SutDescargas { get; set; }

    public virtual DbSet<SutDetalleTelefonoFactura> SutDetalleTelefonoFactura { get; set; }

    public virtual DbSet<SutDireccionesClientes> SutDireccionesClientes { get; set; }

    public virtual DbSet<SutDireccionesUsuarios> SutDireccionesUsuarios { get; set; }

    public virtual DbSet<SutDocumentacion> SutDocumentacion { get; set; }

    public virtual DbSet<SutFacturas> SutFacturas { get; set; }

    public virtual DbSet<SutFacturasPfm> SutFacturasPfm { get; set; }

    public virtual DbSet<SutFichAdjuntos> SutFichAdjuntos { get; set; }

    public virtual DbSet<SutFiltrosListadoAvanzado> SutFiltrosListadoAvanzado { get; set; }

    public virtual DbSet<SutGenerarFacturas> SutGenerarFacturas { get; set; }

    public virtual DbSet<SutGrupos> SutGrupos { get; set; }

    public virtual DbSet<SutHistComentariosLineas> SutHistComentariosLineas { get; set; }

    public virtual DbSet<SutHistModifsUsuario> SutHistModifsUsuario { get; set; }

    public virtual DbSet<SutHistPeticiones> SutHistPeticiones { get; set; }

    public virtual DbSet<SutIncidRefacturacion> SutIncidRefacturacion { get; set; }

    public virtual DbSet<SutIpsBloqueadas> SutIpsBloqueadas { get; set; }

    public virtual DbSet<SutLineas> SutLineas { get; set; }

    public virtual DbSet<SutMovimientosEura> SutMovimientosEura { get; set; }

    public virtual DbSet<SutNorma19> SutNorma19 { get; set; }

    public virtual DbSet<SutNumerosEspeciales> SutNumerosEspeciales { get; set; }

    public virtual DbSet<SutPagosFactura> SutPagosFactura { get; set; }

    public virtual DbSet<SutPenalizaciones> SutPenalizaciones { get; set; }

    public virtual DbSet<SutPerfilasociacionUsuario> SutPerfilasociacionUsuario { get; set; }

    public virtual DbSet<SutPerfiles> SutPerfiles { get; set; }

    public virtual DbSet<SutPeticionesIncidencias> SutPeticionesIncidencias { get; set; }

    public virtual DbSet<SutProductosVbp> SutProductosVbp { get; set; }

    public virtual DbSet<SutPromociones> SutPromociones { get; set; }

    public virtual DbSet<SutPuntos> SutPuntos { get; set; }

    public virtual DbSet<SutRefacturacion> SutRefacturacion { get; set; }

    public virtual DbSet<SutRegistroAccesosTablas> SutRegistroAccesosTablas { get; set; }

    public virtual DbSet<SutRegistrovbp> SutRegistrovbp { get; set; }

    public virtual DbSet<SutReparaTerminales> SutReparaTerminales { get; set; }

    public virtual DbSet<SutResultadosSimulacion> SutResultadosSimulacion { get; set; }

    public virtual DbSet<SutResumenConcFactura> SutResumenConcFactura { get; set; }

    public virtual DbSet<SutResumenConcFacturaPfm> SutResumenConcFacturaPfm { get; set; }

    public virtual DbSet<SutServicios> SutServicios { get; set; }

    public virtual DbSet<SutSesionesUsuario> SutSesionesUsuario { get; set; }

    public virtual DbSet<SutSims> SutSims { get; set; }

    public virtual DbSet<SutTareasApiVodafone> SutTareasApiVodafone { get; set; }

    public virtual DbSet<SutTempDetalleTelefonoFactura> SutTempDetalleTelefonoFactura { get; set; }

    public virtual DbSet<SutTempFacturas> SutTempFacturas { get; set; }

    public virtual DbSet<SutTerminales> SutTerminales { get; set; }

    public virtual DbSet<SutTiposPeticiones> SutTiposPeticiones { get; set; }

    public virtual DbSet<SutTokensEmails> SutTokensEmails { get; set; }

    public virtual DbSet<SutUsuarios> SutUsuarios { get; set; }

    public virtual DbSet<SutUsuariosTokens> SutUsuariosTokens { get; set; }

    public virtual DbSet<SutVdmEdicionesProductos> SutVdmEdicionesProductos { get; set; }

    public virtual DbSet<SutVdmHistorico> SutVdmHistorico { get; set; }

    public virtual DbSet<SutVdmSolicitudes> SutVdmSolicitudes { get; set; }

    public virtual DbSet<SutVdmSuscripcionesUsuarios> SutVdmSuscripcionesUsuarios { get; set; }

    public virtual DbSet<SutVdmUsuarios> SutVdmUsuarios { get; set; }

    public virtual DbSet<SutVerifSocios> SutVerifSocios { get; set; }

    public virtual DbSet<Tarifas> Tarifas { get; set; }

    public virtual DbSet<TiposDestino> TiposDestino { get; set; }

    public virtual DbSet<TiposLlamada> TiposLlamada { get; set; }

    public virtual DbSet<TiposServicio> TiposServicio { get; set; }

    public virtual DbSet<TiposTrafico> TiposTrafico { get; set; }

    public virtual DbSet<TmpLineasColectivizar> TmpLineasColectivizar { get; set; }

    public virtual DbSet<TmpSutCuotasServiciosVf> TmpSutCuotasServiciosVf { get; set; }

    public virtual DbSet<TmpTrgVdfDetalleCuotas> TmpTrgVdfDetalleCuotas { get; set; }

    public virtual DbSet<TmpTrgVdfDetalleTelefono> TmpTrgVdfDetalleTelefono { get; set; }

    public virtual DbSet<TmpTrgVdfFacturas> TmpTrgVdfFacturas { get; set; }

    public virtual DbSet<TmpTrgVdfFinanciacion> TmpTrgVdfFinanciacion { get; set; }

    public virtual DbSet<TmpTrgVdfResumenTelefono> TmpTrgVdfResumenTelefono { get; set; }

    public virtual DbSet<TmpVdfResumenFacturacionCompleta> TmpVdfResumenFacturacionCompleta { get; set; }

    public virtual DbSet<TrgCabeceraMovil> TrgCabeceraMovil { get; set; }

    public virtual DbSet<TrgCabeceraVozDatos> TrgCabeceraVozDatos { get; set; }

    public virtual DbSet<TrgCargas> TrgCargas { get; set; }

    public virtual DbSet<TrgCargasFacturas> TrgCargasFacturas { get; set; }

    public virtual DbSet<TrgCompromisos> TrgCompromisos { get; set; }

    public virtual DbSet<TrgConsumoPorEmpleado> TrgConsumoPorEmpleado { get; set; }

    public virtual DbSet<TrgDescuentosSinDescuadre> TrgDescuentosSinDescuadre { get; set; }

    public virtual DbSet<TrgDetalleMovil> TrgDetalleMovil { get; set; }

    public virtual DbSet<TrgDetalleVoz> TrgDetalleVoz { get; set; }

    public virtual DbSet<TrgEmpresas> TrgEmpresas { get; set; }

    public virtual DbSet<TrgErroresFacturacion977> TrgErroresFacturacion977 { get; set; }

    public virtual DbSet<TrgErroresFacturacionMovil> TrgErroresFacturacionMovil { get; set; }

    public virtual DbSet<TrgErroresTarificacion977> TrgErroresTarificacion977 { get; set; }

    public virtual DbSet<TrgErroresTarificacionMovil> TrgErroresTarificacionMovil { get; set; }

    public virtual DbSet<TrgErroresTarificacionMovilDetalle> TrgErroresTarificacionMovilDetalle { get; set; }

    public virtual DbSet<TrgFacturaGlobal> TrgFacturaGlobal { get; set; }

    public virtual DbSet<TrgFacturacion> TrgFacturacion { get; set; }

    public virtual DbSet<TrgFacturacionSinDescuadre> TrgFacturacionSinDescuadre { get; set; }

    public virtual DbSet<TrgGrupoTraficoMovil> TrgGrupoTraficoMovil { get; set; }

    public virtual DbSet<TrgMvstr010> TrgMvstr010 { get; set; }

    public virtual DbSet<TrgMvstr030> TrgMvstr030 { get; set; }

    public virtual DbSet<TrgMvstr050> TrgMvstr050 { get; set; }

    public virtual DbSet<TrgMvstr100> TrgMvstr100 { get; set; }

    public virtual DbSet<TrgMvstr200> TrgMvstr200 { get; set; }

    public virtual DbSet<TrgMvstr300> TrgMvstr300 { get; set; }

    public virtual DbSet<TrgMvstr310> TrgMvstr310 { get; set; }

    public virtual DbSet<TrgMvstr320> TrgMvstr320 { get; set; }

    public virtual DbSet<TrgMvstr330> TrgMvstr330 { get; set; }

    public virtual DbSet<TrgMvstr340> TrgMvstr340 { get; set; }

    public virtual DbSet<TrgMvstr350> TrgMvstr350 { get; set; }

    public virtual DbSet<TrgMvstr700> TrgMvstr700 { get; set; }

    public virtual DbSet<TrgMvstr750> TrgMvstr750 { get; set; }

    public virtual DbSet<TrgMvstr800> TrgMvstr800 { get; set; }

    public virtual DbSet<TrgMvstr850> TrgMvstr850 { get; set; }

    public virtual DbSet<TrgMvstr950> TrgMvstr950 { get; set; }

    public virtual DbSet<TrgMvstr970> TrgMvstr970 { get; set; }

    public virtual DbSet<TrgMvstr990> TrgMvstr990 { get; set; }

    public virtual DbSet<TrgMvstrFactura> TrgMvstrFactura { get; set; }

    public virtual DbSet<TrgOrngAnexo> TrgOrngAnexo { get; set; }

    public virtual DbSet<TrgOrngCabeceraFactura> TrgOrngCabeceraFactura { get; set; }

    public virtual DbSet<TrgOrngConceptosDatos> TrgOrngConceptosDatos { get; set; }

    public virtual DbSet<TrgOrngConceptosEspeciales> TrgOrngConceptosEspeciales { get; set; }

    public virtual DbSet<TrgOrngConceptosMensajes> TrgOrngConceptosMensajes { get; set; }

    public virtual DbSet<TrgOrngConceptosNacionales> TrgOrngConceptosNacionales { get; set; }

    public virtual DbSet<TrgOrngConceptosOtrosCargos> TrgOrngConceptosOtrosCargos { get; set; }

    public virtual DbSet<TrgOrngDesgloseFactura> TrgOrngDesgloseFactura { get; set; }

    public virtual DbSet<TrgTarifasPlanas> TrgTarifasPlanas { get; set; }

    public virtual DbSet<TrgTarifasPlanasDatos> TrgTarifasPlanasDatos { get; set; }

    public virtual DbSet<TrgTarifasPlanasVoz> TrgTarifasPlanasVoz { get; set; }

    public virtual DbSet<TrgTarificacion977> TrgTarificacion977 { get; set; }

    public virtual DbSet<TrgTarificacionMovil> TrgTarificacionMovil { get; set; }

    public virtual DbSet<TrgTarificacionSinDescuadre> TrgTarificacionSinDescuadre { get; set; }

    public virtual DbSet<TrgTel977000000> TrgTel977000000 { get; set; }

    public virtual DbSet<TrgTel977100000> TrgTel977100000 { get; set; }

    public virtual DbSet<TrgTel977100000DetC6> TrgTel977100000DetC6 { get; set; }

    public virtual DbSet<TrgTel977200000> TrgTel977200000 { get; set; }

    public virtual DbSet<TrgTel977200000DetC6> TrgTel977200000DetC6 { get; set; }

    public virtual DbSet<TrgTel977300000> TrgTel977300000 { get; set; }

    public virtual DbSet<TrgTel977300000DetB2> TrgTel977300000DetB2 { get; set; }

    public virtual DbSet<TrgTel977300000DetC5> TrgTel977300000DetC5 { get; set; }

    public virtual DbSet<TrgTel977300000DetC6> TrgTel977300000DetC6 { get; set; }

    public virtual DbSet<TrgTel977301010> TrgTel977301010 { get; set; }

    public virtual DbSet<TrgTel977301010DetC2> TrgTel977301010DetC2 { get; set; }

    public virtual DbSet<TrgTel977301010DetC218> TrgTel977301010DetC218 { get; set; }

    public virtual DbSet<TrgTel977301020> TrgTel977301020 { get; set; }

    public virtual DbSet<TrgTel977301020DetC2> TrgTel977301020DetC2 { get; set; }

    public virtual DbSet<TrgTel977301020DetC220> TrgTel977301020DetC220 { get; set; }

    public virtual DbSet<TrgTel977303010> TrgTel977303010 { get; set; }

    public virtual DbSet<TrgTel977303010DetC1> TrgTel977303010DetC1 { get; set; }

    public virtual DbSet<TrgTel977304010> TrgTel977304010 { get; set; }

    public virtual DbSet<TrgTel977304010DetC1> TrgTel977304010DetC1 { get; set; }

    public virtual DbSet<TrgTel977500000> TrgTel977500000 { get; set; }

    public virtual DbSet<TrgTel977500000DetC3> TrgTel977500000DetC3 { get; set; }

    public virtual DbSet<TrgTel977501010> TrgTel977501010 { get; set; }

    public virtual DbSet<TrgTel977501010DetC2> TrgTel977501010DetC2 { get; set; }

    public virtual DbSet<TrgTel977501010DetC218> TrgTel977501010DetC218 { get; set; }

    public virtual DbSet<TrgTel977501020> TrgTel977501020 { get; set; }

    public virtual DbSet<TrgTel977501020DetC2> TrgTel977501020DetC2 { get; set; }

    public virtual DbSet<TrgTel977501020DetC220> TrgTel977501020DetC220 { get; set; }

    public virtual DbSet<TrgTel977503010> TrgTel977503010 { get; set; }

    public virtual DbSet<TrgTel977503010DetC1> TrgTel977503010DetC1 { get; set; }

    public virtual DbSet<TrgTel977504010> TrgTel977504010 { get; set; }

    public virtual DbSet<TrgTel977504010DetC1> TrgTel977504010DetC1 { get; set; }

    public virtual DbSet<TrgTel977600000> TrgTel977600000 { get; set; }

    public virtual DbSet<TrgTel977600000DetB2> TrgTel977600000DetB2 { get; set; }

    public virtual DbSet<TrgTel977600000DetC3> TrgTel977600000DetC3 { get; set; }

    public virtual DbSet<TrgTel977600040> TrgTel977600040 { get; set; }

    public virtual DbSet<TrgTel977600040DetC1> TrgTel977600040DetC1 { get; set; }

    public virtual DbSet<TrgTel977601010> TrgTel977601010 { get; set; }

    public virtual DbSet<TrgTel977601010DetC2> TrgTel977601010DetC2 { get; set; }

    public virtual DbSet<TrgTel977601010DetC218> TrgTel977601010DetC218 { get; set; }

    public virtual DbSet<TrgTel977601020> TrgTel977601020 { get; set; }

    public virtual DbSet<TrgTel977601020DetC2> TrgTel977601020DetC2 { get; set; }

    public virtual DbSet<TrgTel977601020DetC220> TrgTel977601020DetC220 { get; set; }

    public virtual DbSet<TrgTel977603010> TrgTel977603010 { get; set; }

    public virtual DbSet<TrgTel977603010DetC1> TrgTel977603010DetC1 { get; set; }

    public virtual DbSet<TrgTel977604010> TrgTel977604010 { get; set; }

    public virtual DbSet<TrgTel977604010DetC1> TrgTel977604010DetC1 { get; set; }

    public virtual DbSet<TrgTel977700000> TrgTel977700000 { get; set; }

    public virtual DbSet<TrgTel977700000DetB1> TrgTel977700000DetB1 { get; set; }

    public virtual DbSet<TrgTel977700000DetC3> TrgTel977700000DetC3 { get; set; }

    public virtual DbSet<TrgTel977700005> TrgTel977700005 { get; set; }

    public virtual DbSet<TrgTel977701010> TrgTel977701010 { get; set; }

    public virtual DbSet<TrgTel977701010DetC2> TrgTel977701010DetC2 { get; set; }

    public virtual DbSet<TrgTel977701010DetC218> TrgTel977701010DetC218 { get; set; }

    public virtual DbSet<TrgTel977701020> TrgTel977701020 { get; set; }

    public virtual DbSet<TrgTel977701020DetC2> TrgTel977701020DetC2 { get; set; }

    public virtual DbSet<TrgTel977701020DetC220> TrgTel977701020DetC220 { get; set; }

    public virtual DbSet<TrgTel977702001> TrgTel977702001 { get; set; }

    public virtual DbSet<TrgTel977702001DetC4> TrgTel977702001DetC4 { get; set; }

    public virtual DbSet<TrgTel977702001DetC47> TrgTel977702001DetC47 { get; set; }

    public virtual DbSet<TrgTel977702002> TrgTel977702002 { get; set; }

    public virtual DbSet<TrgTel977702002DetC4> TrgTel977702002DetC4 { get; set; }

    public virtual DbSet<TrgTel977702002DetC410> TrgTel977702002DetC410 { get; set; }

    public virtual DbSet<TrgTel977702003> TrgTel977702003 { get; set; }

    public virtual DbSet<TrgTel977702003DetC2> TrgTel977702003DetC2 { get; set; }

    public virtual DbSet<TrgTel977702003DetC28> TrgTel977702003DetC28 { get; set; }

    public virtual DbSet<TrgTel977702004> TrgTel977702004 { get; set; }

    public virtual DbSet<TrgTel977702004DetC4> TrgTel977702004DetC4 { get; set; }

    public virtual DbSet<TrgTel977702004DetC46> TrgTel977702004DetC46 { get; set; }

    public virtual DbSet<TrgTel977702009> TrgTel977702009 { get; set; }

    public virtual DbSet<TrgTel977702009DetC2> TrgTel977702009DetC2 { get; set; }

    public virtual DbSet<TrgTel977702010> TrgTel977702010 { get; set; }

    public virtual DbSet<TrgTel977702010DetC2> TrgTel977702010DetC2 { get; set; }

    public virtual DbSet<TrgTel977702015> TrgTel977702015 { get; set; }

    public virtual DbSet<TrgTel977702015DetC3> TrgTel977702015DetC3 { get; set; }

    public virtual DbSet<TrgTel977702017> TrgTel977702017 { get; set; }

    public virtual DbSet<TrgTel977702017DetC12> TrgTel977702017DetC12 { get; set; }

    public virtual DbSet<TrgTel977702020> TrgTel977702020 { get; set; }

    public virtual DbSet<TrgTel977702020DetC2> TrgTel977702020DetC2 { get; set; }

    public virtual DbSet<TrgTel977702025> TrgTel977702025 { get; set; }

    public virtual DbSet<TrgTel977702025DetC2> TrgTel977702025DetC2 { get; set; }

    public virtual DbSet<TrgTel977702025DetC215> TrgTel977702025DetC215 { get; set; }

    public virtual DbSet<TrgTel977702030> TrgTel977702030 { get; set; }

    public virtual DbSet<TrgTel977702030DetC5> TrgTel977702030DetC5 { get; set; }

    public virtual DbSet<TrgTel977702032> TrgTel977702032 { get; set; }

    public virtual DbSet<TrgTel977702032DetC5> TrgTel977702032DetC5 { get; set; }

    public virtual DbSet<TrgTel977702034> TrgTel977702034 { get; set; }

    public virtual DbSet<TrgTel977702034DetC4> TrgTel977702034DetC4 { get; set; }

    public virtual DbSet<TrgTel977702036> TrgTel977702036 { get; set; }

    public virtual DbSet<TrgTel977702036DetC2> TrgTel977702036DetC2 { get; set; }

    public virtual DbSet<TrgTel977702038> TrgTel977702038 { get; set; }

    public virtual DbSet<TrgTel977702038DetC2> TrgTel977702038DetC2 { get; set; }

    public virtual DbSet<TrgTel977702040> TrgTel977702040 { get; set; }

    public virtual DbSet<TrgTel977702040DetC7> TrgTel977702040DetC7 { get; set; }

    public virtual DbSet<TrgTel977703010> TrgTel977703010 { get; set; }

    public virtual DbSet<TrgTel977703010DetC1> TrgTel977703010DetC1 { get; set; }

    public virtual DbSet<TrgTel977703020> TrgTel977703020 { get; set; }

    public virtual DbSet<TrgTel977703020DetC4> TrgTel977703020DetC4 { get; set; }

    public virtual DbSet<TrgTel977704010> TrgTel977704010 { get; set; }

    public virtual DbSet<TrgTel977704010DetC1> TrgTel977704010DetC1 { get; set; }

    public virtual DbSet<TrgTel977901000> TrgTel977901000 { get; set; }

    public virtual DbSet<TrgTel977901000DetC1> TrgTel977901000DetC1 { get; set; }

    public virtual DbSet<TrgTel977902000> TrgTel977902000 { get; set; }

    public virtual DbSet<TrgTel977902000DetC1> TrgTel977902000DetC1 { get; set; }

    public virtual DbSet<TrgTel977903000> TrgTel977903000 { get; set; }

    public virtual DbSet<TrgTel977903000DetC2> TrgTel977903000DetC2 { get; set; }

    public virtual DbSet<TrgTel977903000DetC23> TrgTel977903000DetC23 { get; set; }

    public virtual DbSet<TrgTel977TipoTrafico> TrgTel977TipoTrafico { get; set; }

    public virtual DbSet<TrgTeleTipo2> TrgTeleTipo2 { get; set; }

    public virtual DbSet<TrgTeleTipo3> TrgTeleTipo3 { get; set; }

    public virtual DbSet<TrgTramosConsumo> TrgTramosConsumo { get; set; }

    public virtual DbSet<TrgVdfCargosAjustes> TrgVdfCargosAjustes { get; set; }

    public virtual DbSet<TrgVdfCliente> TrgVdfCliente { get; set; }

    public virtual DbSet<TrgVdfCompras> TrgVdfCompras { get; set; }

    public virtual DbSet<TrgVdfCuenta> TrgVdfCuenta { get; set; }

    public virtual DbSet<TrgVdfDescuentos> TrgVdfDescuentos { get; set; }

    public virtual DbSet<TrgVdfDetalleCuotas> TrgVdfDetalleCuotas { get; set; }

    public virtual DbSet<TrgVdfDetalleOtrasCuotas> TrgVdfDetalleOtrasCuotas { get; set; }

    public virtual DbSet<TrgVdfDetalleTelefono> TrgVdfDetalleTelefono { get; set; }

    public virtual DbSet<TrgVdfFactura> TrgVdfFactura { get; set; }

    public virtual DbSet<TrgVdfFinanciacion> TrgVdfFinanciacion { get; set; }

    public virtual DbSet<TrgVdfPago> TrgVdfPago { get; set; }

    public virtual DbSet<TrgVdfPostVenta> TrgVdfPostVenta { get; set; }

    public virtual DbSet<TrgVdfResumenConcFact> TrgVdfResumenConcFact { get; set; }

    public virtual DbSet<TrgVdfResumenFactura> TrgVdfResumenFactura { get; set; }

    public virtual DbSet<TrgVdfResumenTelefono> TrgVdfResumenTelefono { get; set; }

    public virtual DbSet<TrgVdfResumenTelf> TrgVdfResumenTelf { get; set; }

    public virtual DbSet<TrgVdfnAnexo> TrgVdfnAnexo { get; set; }

    public virtual DbSet<TrgVdfnDetalle> TrgVdfnDetalle { get; set; }

    public virtual DbSet<TrgVdfnResumen> TrgVdfnResumen { get; set; }

    public virtual DbSet<TrgVozDatosFactura> TrgVozDatosFactura { get; set; }

    public virtual DbSet<TrgVwCuotasDatosVoz> TrgVwCuotasDatosVoz { get; set; }

    public virtual DbSet<TrgVwCuotasDatosVoz2> TrgVwCuotasDatosVoz2 { get; set; }

    public virtual DbSet<TrgVwCuotasMoviles> TrgVwCuotasMoviles { get; set; }

    public virtual DbSet<TrgVwDescuentosMoviles> TrgVwDescuentosMoviles { get; set; }

    public virtual DbSet<TrgVwDetalleDatosBorrar> TrgVwDetalleDatosBorrar { get; set; }

    public virtual DbSet<TrgVwDetalleVoz> TrgVwDetalleVoz { get; set; }

    public virtual DbSet<TrgVwLineas> TrgVwLineas { get; set; }

    public virtual DbSet<TrgVwMoviTipo1> TrgVwMoviTipo1 { get; set; }

    public virtual DbSet<TrgVwMoviTipo3> TrgVwMoviTipo3 { get; set; }

    public virtual DbSet<TrgVwTeleTipo1> TrgVwTeleTipo1 { get; set; }

    public virtual DbSet<TrgVwVdfnDetalle> TrgVwVdfnDetalle { get; set; }

    public virtual DbSet<TrgVwVdfnResumen> TrgVwVdfnResumen { get; set; }

    public virtual DbSet<TrgVwVdfnTipo1> TrgVwVdfnTipo1 { get; set; }

    public virtual DbSet<TrgVwVdfnTipo3> TrgVwVdfnTipo3 { get; set; }

    public virtual DbSet<UbicacionEmpleados> UbicacionEmpleados { get; set; }

    public virtual DbSet<UnidadMedida> UnidadMedida { get; set; }

    public virtual DbSet<Usuarios> Usuarios { get; set; }

    public virtual DbSet<VdfClientesFibra> VdfClientesFibra { get; set; }

    public virtual DbSet<VdfComprasFibra> VdfComprasFibra { get; set; }

    public virtual DbSet<VdfConsumosFibra> VdfConsumosFibra { get; set; }

    public virtual DbSet<VdfServiciosFibra> VdfServiciosFibra { get; set; }

    public virtual DbSet<VodafoneInventario> VodafoneInventario { get; set; }

  //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//arning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
   //     => optionsBuilder.UseSqlServer("Data Source=192.168.0.14,61344;Initial Catalog=dbo;Persist Security Info=True;User ID=alternativesa;Password=secret_2022;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcuerdosMarcoVirtuales>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CuotasAcuerdoVirtual).HasMaxLength(4000);
            entity.Property(e => e.DescAcuerdoVirtual).HasMaxLength(4000);
            entity.Property(e => e.Idempresa).HasColumnName("IDEmpresa");
        });

        modelBuilder.Entity<AcuerdosTarificacion>(entity =>
        {
            entity.HasKey(e => new { e.Identificador, e.IdOperadora, e.TablaParametro, e.IdEmpresa, e.NumAcuerdoMarco });

            entity.Property(e => e.Identificador)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdOperadora).HasColumnName("idOperadora");
            entity.Property(e => e.TablaParametro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.DescValParametro)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DescValParametroEst)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaFin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteEst)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Parametros).IsUnicode(false);
            entity.Property(e => e.Precio)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sumar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TablaParametroEst)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValParametro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValParametroEst)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Agrupado700000>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Agrupado700000");

            entity.Property(e => e.CodMulticon)
                .HasMaxLength(2)
                .HasColumnName("codMulticon");
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.DomicilioTa)
                .HasMaxLength(50)
                .HasColumnName("DomicilioTA");
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.FechaAlta).HasMaxLength(50);
            entity.Property(e => e.FechaBaja).HasMaxLength(50);
            entity.Property(e => e.FechaFactura).HasColumnType("smalldatetime");
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.PoblacionTa)
                .HasMaxLength(50)
                .HasColumnName("PoblacionTA");
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<Agrupado901000DetC1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Agrupado901000_DET_C1");

            entity.Property(e => e.CodigoExterno).HasMaxLength(50);
            entity.Property(e => e.CodigoInterno).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasMaxLength(180);
        });

        modelBuilder.Entity<CamposExportacion>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Carrel)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CARREL");
            entity.Property(e => e.Imcamp).HasColumnName("IMCAMP");
            entity.Property(e => e.Nocamp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOCAMP");
            entity.Property(e => e.Ordenv).HasColumnName("ORDENV");
            entity.Property(e => e.Tacamp)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("TACAMP");
            entity.Property(e => e.Ticamp)
                .HasMaxLength(1)
                .HasColumnName("TICAMP");
        });

        modelBuilder.Entity<CfDatosActivos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CF_DATOS_ACTIVOS");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ntelef)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("ntelef");
        });

        modelBuilder.Entity<CfDetCobrointernas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CF_DET_COBROINTERNAS");

            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.FechaHora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA_HORA");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE_NETO");
            entity.Property(e => e.NoRecep)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NO_RECEP");
            entity.Property(e => e.Telef2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
            entity.Property(e => e.TelefExt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF_EXT");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<CfDetmvCobrointernas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CF_DETMV_COBROINTERNAS");

            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.FechaHora)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FECHA_HORA");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("IMPORTE_NETO");
            entity.Property(e => e.NoRecep)
                .HasMaxLength(50)
                .HasColumnName("NO_RECEP");
            entity.Property(e => e.Telef2)
                .HasMaxLength(50)
                .HasColumnName("TELEF2");
            entity.Property(e => e.TelefExt)
                .HasMaxLength(50)
                .HasColumnName("TELEF_EXT");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<CfPerfilConsumo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CF_PERFIL_CONSUMO");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ntelef)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("ntelef");
        });

        modelBuilder.Entity<CfResCfactura>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CF_RES_CFACTURA");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.LblGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LBL_GRUPO");
            entity.Property(e => e.LblTipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LBL_TIPO");
            entity.Property(e => e.MinutosKb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MINUTOS_KB");
            entity.Property(e => e.NLlamadas).HasColumnName("N_LLAMADAS");
            entity.Property(e => e.NumServ)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUM_SERV");
            entity.Property(e => e.Titular)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TITULAR");
        });

        modelBuilder.Entity<CfResConsumo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CF_RES_CONSUMO");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Coddestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODDESTINO");
            entity.Property(e => e.Codllamada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODLLAMADA");
            entity.Property(e => e.Duracion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURACION");
            entity.Property(e => e.Duraciondatos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURACIONDATOS");
            entity.Property(e => e.Importe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE");
            entity.Property(e => e.ImporteAm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE_AM");
            entity.Property(e => e.Importedatos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTEDATOS");
            entity.Property(e => e.Ntelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NTELEFONO");
            entity.Property(e => e.Tipodestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPODESTINO");
            entity.Property(e => e.Titular)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TITULAR");
        });

        modelBuilder.Entity<CfResConsumodatos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CF_RES_CONSUMODATOS");

            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFACTURA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ntelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NTELEFONO");
            entity.Property(e => e.Sumaimporte)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("sumaimporte");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<CfResConsumominimo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CF_RES_CONSUMOMINIMO");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.SumaDeImporte)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("SumaDeIMPORTE");
            entity.Property(e => e.SumaDeImporteNeto)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("SumaDeIMPORTE_NETO");
            entity.Property(e => e.Telef2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
            entity.Property(e => e.Tipo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Tipocons)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TIPOCONS");
        });

        modelBuilder.Entity<CfResmvConsumodatos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CF_RESMV_CONSUMODATOS");

            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.Sumaimporte)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("sumaimporte");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<CfResumenTelf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CF_RESUMEN_TELF");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Consumo)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CONSUMO");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUENTA");
            entity.Property(e => e.CuentaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUENTA_NO");
            entity.Property(e => e.CuotaMes)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CUOTA_MES");
            entity.Property(e => e.Descuentos)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DESCUENTOS");
            entity.Property(e => e.MsintCant).HasColumnName("MSINT_CANT");
            entity.Property(e => e.MsintEuros)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MSINT_EUROS");
            entity.Property(e => e.MsmnvCant).HasColumnName("MSMNV_CANT");
            entity.Property(e => e.MsmnvEuros)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MSMNV_EUROS");
            entity.Property(e => e.MsmvCant).HasColumnName("MSMV_CANT");
            entity.Property(e => e.MsmvEuros)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MSMV_EUROS");
            entity.Property(e => e.OtrasCuot)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OTRAS_CUOT");
            entity.Property(e => e.OtrosAb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OTROS_AB");
            entity.Property(e => e.OtrosCar)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OTROS_CAR");
            entity.Property(e => e.Telef)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("TELEF");
            entity.Property(e => e.Titular)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TITULAR");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.TotalCantidad).HasColumnName("TOTAL_CANTIDAD");
            entity.Property(e => e.TotalEuros)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTAL_EUROS");
        });

        modelBuilder.Entity<ComparativoAcuerdos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.Identificador1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Identificador2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Parametros1).IsUnicode(false);
            entity.Property(e => e.Parametros2).IsUnicode(false);
            entity.Property(e => e.TipoEntrada)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Conceptos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<ConceptosAgrupacion>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Concepto)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Mantenimiento).HasMaxLength(50);
        });

        modelBuilder.Entity<ConceptosFacturables>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ConceptosFacturables");

            entity.Property(e => e.CodigoExterno).HasMaxLength(50);
            entity.Property(e => e.CodigoInterno).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasMaxLength(180);
        });

        modelBuilder.Entity<CondicionesAcuerdosMarco>(entity =>
        {
            entity.HasKey(e => new { e.Idempresa, e.Idoperadora, e.NumAcuerdoMarco, e.Identificador });

            entity.Property(e => e.Idempresa).HasColumnName("IDEmpresa");
            entity.Property(e => e.Idoperadora).HasColumnName("IDOperadora");
            entity.Property(e => e.Identificador).HasMaxLength(50);
            entity.Property(e => e.Domingo).HasMaxLength(50);
            entity.Property(e => e.Jueves).HasMaxLength(50);
            entity.Property(e => e.Lunes).HasMaxLength(50);
            entity.Property(e => e.Martes).HasMaxLength(50);
            entity.Property(e => e.Miercoles).HasMaxLength(50);
            entity.Property(e => e.Sabado).HasMaxLength(50);
            entity.Property(e => e.Viernes).HasMaxLength(50);
        });

        modelBuilder.Entity<ConsumoResponsableEmpleado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ConsumoResponsable_Empleado");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Cuotas).HasColumnName("cuotas");
            entity.Property(e => e.DescCuotas).HasColumnName("descCuotas");
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Descuentos).HasColumnName("descuentos");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NombreEmpleado)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE_EMPLEADO");
            entity.Property(e => e.NombreResponsable)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE_RESPONSABLE");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(255)
                .HasColumnName("PRIMER_APELLIDO");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(255)
                .HasColumnName("SEGUNDO_APELLIDO");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Unidades).HasMaxLength(250);
            entity.Property(e => e.Varios).HasColumnName("varios");
        });

        modelBuilder.Entity<ConsumoTipoTraficoPorEmpleado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ConsumoTipoTraficoPorEmpleado");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cantmedida).HasColumnName("cantmedida");
            entity.Property(e => e.DescArea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MarcAbrev)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.NTelfConex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nTelfConex");
            entity.Property(e => e.NombreEmpleado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
            entity.Property(e => e.UnidadMedida).HasMaxLength(50);
            entity.Property(e => e.Ush)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USH");
        });

        modelBuilder.Entity<DetalleInventarioLineas702010DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Detalle_InventarioLineas_702010_det_c2");

            entity.Property(e => e.AmbitoLlamada)
                .HasMaxLength(50)
                .HasColumnName("AmbitoLLamada");
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPer).HasMaxLength(50);
            entity.Property(e => e.DescProyecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Destino).HasMaxLength(50);
            entity.Property(e => e.DuracionLlamada)
                .HasMaxLength(50)
                .HasColumnName("DuracionLLamada");
            entity.Property(e => e.Fllamada)
                .HasMaxLength(50)
                .HasColumnName("FLlamada");
            entity.Property(e => e.HoraInicio).HasMaxLength(50);
            entity.Property(e => e.ImporteValor).HasMaxLength(50);
            entity.Property(e => e.LlamadaCorportativa)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nsolicitado)
                .HasMaxLength(50)
                .HasColumnName("NSolicitado");
            entity.Property(e => e.NumeroLlamado)
                .HasMaxLength(50)
                .HasColumnName("NumeroLLamado");
            entity.Property(e => e.OperadorProveedor).HasMaxLength(50);
            entity.Property(e => e.Tarifa).HasMaxLength(50);
            entity.Property(e => e.Ush)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USH");
        });

        modelBuilder.Entity<DetalleLlamadasMovistar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DetalleLlamadasMovistar");

            entity.Property(e => e.Cantmedidaoriginada).HasColumnName("CANTMEDIDAORIGINADA");
            entity.Property(e => e.Cantmedidarecibida).HasColumnName("CANTMEDIDARECIBIDA");
            entity.Property(e => e.Coddestino)
                .HasMaxLength(50)
                .HasColumnName("CODDESTINO");
            entity.Property(e => e.Codllamada)
                .HasMaxLength(50)
                .HasColumnName("CODLLAMADA");
            entity.Property(e => e.Codtrafico)
                .HasMaxLength(50)
                .HasColumnName("CODTRAFICO");
            entity.Property(e => e.DescArea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dia).HasMaxLength(2);
            entity.Property(e => e.Fecha)
                .HasMaxLength(5)
                .HasColumnName("FECHA");
            entity.Property(e => e.Franja)
                .HasMaxLength(50)
                .HasColumnName("FRANJA");
            entity.Property(e => e.Horainicio)
                .HasMaxLength(8)
                .HasColumnName("HORAINICIO");
            entity.Property(e => e.Importe)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.Importedatos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IMPORTEDATOS");
            entity.Property(e => e.LlamadaCorporativa)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasMaxLength(2);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nllamado)
                .HasMaxLength(50)
                .HasColumnName("NLlamado");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.Operadordestino)
                .HasMaxLength(50)
                .HasColumnName("OPERADORDESTINO");
            entity.Property(e => e.Operadororigen).HasColumnName("OPERADORORIGEN");
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .HasColumnName("TARIFA");
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
            entity.Property(e => e.Tipodestino)
                .HasMaxLength(50)
                .HasColumnName("TIPODESTINO");
            entity.Property(e => e.Tipollamada)
                .HasMaxLength(50)
                .HasColumnName("TIPOLLAMADA");
            entity.Property(e => e.Unidadmedida)
                .HasMaxLength(50)
                .HasColumnName("UNIDADMEDIDA");
            entity.Property(e => e.Ush)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USH");
        });

        modelBuilder.Entity<DimConcepto>(entity =>
        {
            entity.HasKey(e => e.ConceptoKey);

            entity.ToTable("Dim_Concepto");

            entity.Property(e => e.ConceptoKey).HasColumnName("Concepto_Key");
            entity.Property(e => e.ConceptoCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Concepto_Cod");
            entity.Property(e => e.ConceptoDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Concepto_Descripcion");
            entity.Property(e => e.ConceptoPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Concepto_PCod");
            entity.Property(e => e.ConceptoPkey).HasColumnName("Concepto_PKey");
        });

        modelBuilder.Entity<DimConceptoFactura>(entity =>
        {
            entity.HasKey(e => e.ConceptoKey);

            entity.ToTable("Dim_ConceptoFactura");

            entity.Property(e => e.ConceptoKey).HasColumnName("Concepto_Key");
            entity.Property(e => e.ConceptoCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Concepto_Cod");
            entity.Property(e => e.ConceptoDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Concepto_Descripcion");
            entity.Property(e => e.ConceptoPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Concepto_PCod");
            entity.Property(e => e.ConceptoPkey).HasColumnName("Concepto_PKey");
        });

        modelBuilder.Entity<DimDestino>(entity =>
        {
            entity.HasKey(e => e.DestinoKey);

            entity.ToTable("Dim_Destino");

            entity.Property(e => e.DestinoKey).HasColumnName("Destino_Key");
            entity.Property(e => e.DestinoCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Destino_Cod");
            entity.Property(e => e.DestinoDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Destino_Descripcion");
            entity.Property(e => e.DestinoPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Destino_PCod");
            entity.Property(e => e.DestinoPkey).HasColumnName("Destino_PKey");
        });

        modelBuilder.Entity<DimFactura>(entity =>
        {
            entity.HasKey(e => e.FacturaKey);

            entity.ToTable("Dim_Factura");

            entity.Property(e => e.FacturaKey).HasColumnName("Factura_Key");
            entity.Property(e => e.FacturaCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Factura_Cod");
            entity.Property(e => e.FacturaDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Factura_Descripcion");
            entity.Property(e => e.FacturaPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Factura_PCod");
            entity.Property(e => e.FacturaPkey).HasColumnName("Factura_PKey");
        });

        modelBuilder.Entity<DimFecha>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Dim_Fecha");

            entity.Property(e => e.Año)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Dia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mes)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PeriodoKey).HasColumnName("Periodo_Key");
        });

        modelBuilder.Entity<DimGeografia>(entity =>
        {
            entity.HasKey(e => e.GeografiaKey);

            entity.ToTable("Dim_Geografia");

            entity.Property(e => e.GeografiaKey).HasColumnName("Geografia_Key");
            entity.Property(e => e.GeografiaAct).HasColumnName("Geografia_Act");
            entity.Property(e => e.GeografiaCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Geografia_Cod");
            entity.Property(e => e.GeografiaDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Geografia_Descripcion");
            entity.Property(e => e.GeografiaDireccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Geografia_Direccion");
            entity.Property(e => e.GeografiaPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Geografia_PCod");
            entity.Property(e => e.GeografiaPkey).HasColumnName("Geografia_PKey");
        });

        modelBuilder.Entity<DimLinea>(entity =>
        {
            entity.HasKey(e => e.LineaKey);

            entity.ToTable("Dim_Linea");

            entity.Property(e => e.LineaKey).HasColumnName("Linea_Key");
            entity.Property(e => e.LineaAct).HasColumnName("Linea_Act");
            entity.Property(e => e.LineaCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Linea_Cod");
            entity.Property(e => e.LineaDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Linea_Descripcion");
            entity.Property(e => e.LineaPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Linea_PCod");
            entity.Property(e => e.LineaPkey).HasColumnName("Linea_PKey");
            entity.Property(e => e.LineaSubTipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Linea_SubTipo");
            entity.Property(e => e.LineaTipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Linea_Tipo");
        });

        modelBuilder.Entity<DimOperador>(entity =>
        {
            entity.HasKey(e => e.OperadorKey);

            entity.ToTable("Dim_Operador");

            entity.Property(e => e.OperadorKey).HasColumnName("Operador_Key");
            entity.Property(e => e.OperadorCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Operador_Cod");
            entity.Property(e => e.OperadorDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Operador_Descripcion");
            entity.Property(e => e.OperadorPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Operador_PCod");
            entity.Property(e => e.OperadorPkey).HasColumnName("Operador_PKey");
        });

        modelBuilder.Entity<DimTarifa>(entity =>
        {
            entity.HasKey(e => e.TarifaKey);

            entity.ToTable("Dim_Tarifa");

            entity.Property(e => e.TarifaKey).HasColumnName("Tarifa_Key");
            entity.Property(e => e.TarifaCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tarifa_Cod");
            entity.Property(e => e.TarifaDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tarifa_Descripcion");
            entity.Property(e => e.TarifaPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tarifa_PCod");
            entity.Property(e => e.TarifaPkey).HasColumnName("Tarifa_PKey");
        });

        modelBuilder.Entity<DimTipoAmbito>(entity =>
        {
            entity.HasKey(e => e.AmbitoKey);

            entity.ToTable("Dim_TipoAmbito");

            entity.Property(e => e.AmbitoKey).HasColumnName("Ambito_Key");
            entity.Property(e => e.AmbitoCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ambito_Cod");
            entity.Property(e => e.AmbitoDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Ambito_Descripcion");
            entity.Property(e => e.AmbitoPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ambito_PCod");
            entity.Property(e => e.AmbitoPkey).HasColumnName("Ambito_PKey");
        });

        modelBuilder.Entity<DimTipoLlamada>(entity =>
        {
            entity.HasKey(e => e.LlamadaKey);

            entity.ToTable("Dim_TipoLlamada");

            entity.Property(e => e.LlamadaKey).HasColumnName("Llamada_Key");
            entity.Property(e => e.LlamadaCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Llamada_Cod");
            entity.Property(e => e.LlamadaDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Llamada_Descripcion");
            entity.Property(e => e.LlamadaPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Llamada_PCod");
            entity.Property(e => e.LlamadaPkey).HasColumnName("Llamada_PKey");
        });

        modelBuilder.Entity<DimTipoServicio>(entity =>
        {
            entity.HasKey(e => e.ServicioKey);

            entity.ToTable("Dim_TipoServicio");

            entity.Property(e => e.ServicioKey).HasColumnName("Servicio_Key");
            entity.Property(e => e.ServicioCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Servicio_Cod");
            entity.Property(e => e.ServicioDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Servicio_Descripcion");
            entity.Property(e => e.ServicioPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Servicio_PCod");
            entity.Property(e => e.ServicioPkey).HasColumnName("Servicio_PKey");
        });

        modelBuilder.Entity<DimTipoTrafico>(entity =>
        {
            entity.HasKey(e => e.TraficoKey);

            entity.ToTable("Dim_TipoTrafico");

            entity.Property(e => e.TraficoKey).HasColumnName("Trafico_Key");
            entity.Property(e => e.TraficoCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Trafico_Cod");
            entity.Property(e => e.TraficoDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Trafico_Descripcion");
            entity.Property(e => e.TraficoPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Trafico_PCod");
            entity.Property(e => e.TraficoPkey).HasColumnName("Trafico_PKey");
        });

        modelBuilder.Entity<DimTramosConsumo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Dim_Tramos_Consumo");

            entity.Property(e => e.DescTramo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descTramo");
            entity.Property(e => e.IdTramo).HasColumnName("idTramo");
            entity.Property(e => e.Inferior).HasColumnName("inferior");
            entity.Property(e => e.Superior).HasColumnName("superior");
        });

        modelBuilder.Entity<DimUnidadMedida>(entity =>
        {
            entity.HasKey(e => e.MedidaKey);

            entity.ToTable("Dim_UnidadMedida");

            entity.Property(e => e.MedidaKey).HasColumnName("Medida_Key");
            entity.Property(e => e.MedidaCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Medida_Cod");
            entity.Property(e => e.MedidaDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Medida_Descripcion");
            entity.Property(e => e.MedidaPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Medida_PCod");
            entity.Property(e => e.MedidaPkey).HasColumnName("Medida_PKey");
        });

        modelBuilder.Entity<DimUnidadesFuncional>(entity =>
        {
            entity.HasKey(e => e.FuncionalKey).HasName("PK_Dim_UnidadesFuncional_1");

            entity.ToTable("Dim_UnidadesFuncional");

            entity.Property(e => e.FuncionalKey).HasColumnName("Funcional_Key");
            entity.Property(e => e.FuncionalAct).HasColumnName("Funcional_Act");
            entity.Property(e => e.FuncionalCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Funcional_Cod");
            entity.Property(e => e.FuncionalDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Funcional_Descripcion");
            entity.Property(e => e.FuncionalEsPersona).HasColumnName("Funcional_EsPersona");
            entity.Property(e => e.FuncionalNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Funcional_Nombre");
            entity.Property(e => e.FuncionalPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Funcional_PCod");
            entity.Property(e => e.FuncionalPkey).HasColumnName("Funcional_PKey");
            entity.Property(e => e.FuncionalUsuarioRed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Funcional_UsuarioRed");
        });

        modelBuilder.Entity<DimUnidadesGestion>(entity =>
        {
            entity.HasKey(e => e.GestionKey);

            entity.ToTable("Dim_UnidadesGestion");

            entity.Property(e => e.GestionKey).HasColumnName("Gestion_Key");
            entity.Property(e => e.GestionAct).HasColumnName("Gestion_Act");
            entity.Property(e => e.GestionCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Gestion_Cod");
            entity.Property(e => e.GestionDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Gestion_Descripcion");
            entity.Property(e => e.GestionNivel).HasColumnName("Gestion_Nivel");
            entity.Property(e => e.GestionNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Gestion_Nombre");
            entity.Property(e => e.GestionPcod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Gestion_PCod");
            entity.Property(e => e.GestionPkey).HasColumnName("Gestion_PKey");
            entity.Property(e => e.GestionUsuarioRed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Gestion_UsuarioRed");
        });

        modelBuilder.Entity<Empresas>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AutogestionSms).HasColumnName("AutogestionSMS");
            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.CuentaBase)
                .HasMaxLength(12)
                .HasColumnName("Cuenta_base");
            entity.Property(e => e.CuentaIva)
                .HasMaxLength(12)
                .HasColumnName("Cuenta_iva");
            entity.Property(e => e.Descripcion).HasMaxLength(1000);
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.DniAdminLegal)
                .HasMaxLength(9)
                .HasColumnName("dni_admin_legal");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EmailFacturacion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaDesdeAgente).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaHastaAgente).HasColumnType("datetime");
            entity.Property(e => e.FechaModif).HasColumnType("datetime");
            entity.Property(e => e.FechaOrdenDomiciliacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_orden_domiciliacion");
            entity.Property(e => e.FormaPago).HasMaxLength(25);
            entity.Property(e => e.Franquicia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FranquiciaMax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdAgente).HasColumnName("idAgente");
            entity.Property(e => e.IdCatalogo).HasColumnName("ID_CATALOGO");
            entity.Property(e => e.IdcVinculada).HasColumnName("IDC_VINCULADA");
            entity.Property(e => e.MargenColectivo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MargenTerminal).HasMaxLength(15);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NombreAdminLegal)
                .HasMaxLength(255)
                .HasColumnName("nombre_admin_legal");
            entity.Property(e => e.NombreBanco)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(50)
                .HasColumnName("nombreComercial");
            entity.Property(e => e.Num)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Contador Serie General");
            entity.Property(e => e.Num2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Contador Informativas");
            entity.Property(e => e.Num3).HasComment("Contador Serie Abonos");
            entity.Property(e => e.NumCuenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlanPrecios)
                .HasMaxLength(15)
                .HasColumnName("PLAN_PRECIOS");
            entity.Property(e => e.PorcentajeDescuentoColectivo).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.PorcentajeDtoCatalogoOp).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.RefOrdenDomiciliacion)
                .HasMaxLength(35)
                .HasColumnName("ref_orden_domiciliacion");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Serie General");
            entity.Property(e => e.Serie3)
                .HasMaxLength(50)
                .HasComment("Serie Abonos");
            entity.Property(e => e.SerieR)
                .HasMaxLength(50)
                .HasComment("Serie Revendedor");
            entity.Property(e => e.SufijoNorma19).HasMaxLength(3);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoAsesor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpresasAnexo>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa);

            entity.ToTable("Empresas_Anexo");

            entity.Property(e => e.IdEmpresa)
                .ValueGeneratedNever()
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.AbreviaturasColectivo)
                .HasMaxLength(250)
                .HasColumnName("ABREVIATURAS_COLECTIVO");
            entity.Property(e => e.ActivacionVbp).HasColumnName("ACTIVACION_VBP");
            entity.Property(e => e.AvisoxMail).HasColumnName("AVISOxMAIL");
            entity.Property(e => e.AvisoxSms).HasColumnName("AVISOxSMS");
            entity.Property(e => e.BolsaEura)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BOLSA_EURA");
            entity.Property(e => e.BolsaEuroVf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BOLSA_EURO_VF");
            entity.Property(e => e.CarpetaColectivo)
                .HasMaxLength(255)
                .HasColumnName("carpetaColectivo");
            entity.Property(e => e.ChkUsoApicambioSim)
                .HasDefaultValue((short)0)
                .HasColumnName("chkUsoAPICambioSIM");
            entity.Property(e => e.Ciclo).HasColumnName("CICLO");
            entity.Property(e => e.CicloAvancoop).HasColumnName("CICLO_AVANCOOP");
            entity.Property(e => e.CkCabeceraFacturable).HasColumnName("ckCabeceraFacturable");
            entity.Property(e => e.CkCompilacionFacturas).HasColumnName("ckCompilacionFacturas");
            entity.Property(e => e.CkCosteCorreoPostal).HasColumnName("ckCosteCorreoPostal");
            entity.Property(e => e.CkFacturacionporLinea).HasColumnName("ckFacturacionporLinea");
            entity.Property(e => e.CkFijosNacionalesGratis).HasColumnName("ckFijosNacionalesGratis");
            entity.Property(e => e.CkMargenCoop).HasColumnName("ckMargenCoop");
            entity.Property(e => e.CkMargenHbdcoop).HasColumnName("ckMargenHBDCoop");
            entity.Property(e => e.CkTarifaPlanaGcu).HasColumnName("ckTarifaPlanaGCU");
            entity.Property(e => e.ClaveRecibosc19)
                .HasMaxLength(2)
                .HasColumnName("CLAVE_RECIBOSC19");
            entity.Property(e => e.CompromisoSustitucion).HasColumnName("COMPROMISO_SUSTITUCION");
            entity.Property(e => e.CuentaVf)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CUENTA_VF");
            entity.Property(e => e.CuotaConsumoMinimoCoop)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CUOTA_CONSUMO_MINIMO_COOP");
            entity.Property(e => e.DuracionMesesContratoVf).HasColumnName("DURACION_MESES_CONTRATO_VF");
            entity.Property(e => e.EuroVfXLinea)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EURO_VF_X_LINEA");
            entity.Property(e => e.FechaUltimaRenovacionContratoVf)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ULTIMA_RENOVACION_CONTRATO_VF");
            entity.Property(e => e.Fidelizacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIDELIZACION");
            entity.Property(e => e.FidelizacionEura).HasColumnName("FIDELIZACION_EURA");
            entity.Property(e => e.FinanciaTerminales).HasColumnName("FINANCIA_TERMINALES");
            entity.Property(e => e.IdComercialvd).HasColumnName("ID_COMERCIALVD");
            entity.Property(e => e.IdSoportevd).HasColumnName("ID_SOPORTEVD");
            entity.Property(e => e.IdclienteGestCobro).HasColumnName("IDCLIENTE_GEST_COBRO");
            entity.Property(e => e.MovilCobroVbp)
                .HasMaxLength(9)
                .HasColumnName("MOVIL_COBRO_VBP");
            entity.Property(e => e.MsgAltaLinea)
                .HasMaxLength(4000)
                .HasColumnName("MSG_ALTA_LINEA");
            entity.Property(e => e.MsgAltaUsuario)
                .HasMaxLength(4000)
                .HasColumnName("MSG_ALTA_USUARIO");
            entity.Property(e => e.NotificarAvisosEmail).HasColumnName("NOTIFICAR_AVISOS_EMAIL");
            entity.Property(e => e.ParamsBranding)
                .HasMaxLength(1000)
                .HasColumnName("PARAMS_BRANDING");
            entity.Property(e => e.PenalizacionBaja)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PENALIZACION_BAJA");
            entity.Property(e => e.PermiteSubcuentas).HasColumnName("PERMITE_SUBCUENTAS");
            entity.Property(e => e.PersonaContactoPosventas).HasMaxLength(255);
            entity.Property(e => e.RangoExt).HasMaxLength(15);
            entity.Property(e => e.RestriccionesPorDefecto).HasMaxLength(1000);
            entity.Property(e => e.RevendedorDe).HasColumnName("REVENDEDOR_DE");
            entity.Property(e => e.ServFirmaManuscrita).HasColumnName("SERV_FIRMA_MANUSCRITA");
            entity.Property(e => e.SgPack).HasColumnName("SG_PACK");
            entity.Property(e => e.TlfnoPersonaContactoPosventas).HasMaxLength(9);
            entity.Property(e => e.VfPack).HasColumnName("VF_PACK");
        });

        modelBuilder.Entity<EstablecimientoLlamadas>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DescValParametro)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.IdOperadora).HasColumnName("idOperadora");
            entity.Property(e => e.Importe)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TablaParametro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValParametro)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FacturacionSigestelxCiclo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FacturacionSigestelxCiclo");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CodConcepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Telef)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("TELEF");
        });

        modelBuilder.Entity<FijaProyecto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FijaProyecto");

            entity.Property(e => e.Cif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIF");
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.DescArea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteFija).HasColumnType("numeric(38, 4)");
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NTelfConex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nTelfConex");
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TipoProyecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ush)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USH");
        });

        modelBuilder.Entity<GruposUsuarios>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.IdGrupo).HasColumnName("idGrupo");
        });

        modelBuilder.Entity<ImportePorLineaDatos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ImportePorLineaDatos");

            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoPostal).HasMaxLength(50);
            entity.Property(e => e.DomicilioTa)
                .HasMaxLength(50)
                .HasColumnName("DomicilioTA");
            entity.Property(e => e.FechaAlta).HasMaxLength(50);
            entity.Property(e => e.FechaBaja).HasMaxLength(50);
            entity.Property(e => e.FechaFactura).HasColumnType("smalldatetime");
            entity.Property(e => e.Importe).HasColumnName("importe");
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.PoblacionTa)
                .HasMaxLength(50)
                .HasColumnName("PoblacionTA");
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<InvarioVozTrafico>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("InvarioVozTrafico");

            entity.Property(e => e.AmbitoLlamada)
                .HasMaxLength(50)
                .HasColumnName("AmbitoLLamada");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.DescAmbitoLlamada).HasMaxLength(180);
            entity.Property(e => e.DescProyecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescServicio).HasMaxLength(180);
            entity.Property(e => e.DomicilioTa)
                .HasMaxLength(50)
                .HasColumnName("DomicilioTA");
            entity.Property(e => e.Empresa)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.LlamadaCorportativa)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NumeroLlamado)
                .HasMaxLength(50)
                .HasColumnName("NumeroLLamado");
            entity.Property(e => e.OperadorProveedor).HasMaxLength(180);
            entity.Property(e => e.PoblacionTa)
                .HasMaxLength(50)
                .HasColumnName("PoblacionTA");
            entity.Property(e => e.Ush)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USH");
        });

        modelBuilder.Entity<InventarioLineas>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Agrupacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Calle).IsUnicode(false);
            entity.Property(e => e.Centro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cif)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodMulticonex)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProyecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescArea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescProyecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Direccion).IsUnicode(false);
            entity.Property(e => e.Distancia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.Empresa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAltaOp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBajaOp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaUltimaFact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaVigencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpleado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idEmpleado");
            entity.Property(e => e.IdOperadora).HasColumnName("idOperadora");
            entity.Property(e => e.IndCentralita)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Limite)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MarcAbrev)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaxIdUsuarioResponsable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Max Id UsuarioResponsable");
            entity.Property(e => e.MostrarEnWeb)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NTelfConex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nTelfConex");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreEmpleado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PerfilRestrictivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sim)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Subtipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoServicio).IsUnicode(false);
            entity.Property(e => e.Ush)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USH");
            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InventarioLineas2>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Centralita).HasMaxLength(255);
            entity.Property(e => e.Centro).HasMaxLength(255);
            entity.Property(e => e.Descripción).HasMaxLength(255);
            entity.Property(e => e.DescripciónProyecto)
                .HasMaxLength(255)
                .HasColumnName("Descripción Proyecto");
            entity.Property(e => e.DescripciónUsh)
                .HasMaxLength(255)
                .HasColumnName("Descripción USH");
            entity.Property(e => e.DescripciónÁrea)
                .HasMaxLength(255)
                .HasColumnName("Descripción Área");
            entity.Property(e => e.Dni)
                .HasMaxLength(255)
                .HasColumnName("DNI");
            entity.Property(e => e.Empleado).HasMaxLength(255);
            entity.Property(e => e.Empresa).HasMaxLength(255);
            entity.Property(e => e.Estado).HasMaxLength(255);
            entity.Property(e => e.FEfva)
                .HasMaxLength(255)
                .HasColumnName("F Efva");
            entity.Property(e => e.Field19).HasMaxLength(255);
            entity.Property(e => e.MarcAbreviada).HasColumnName("Marc Abreviada");
            entity.Property(e => e.MaxIdUsuarioResponsable)
                .HasMaxLength(255)
                .HasColumnName("Max id UsuarioResponsable");
            entity.Property(e => e.Mostrar).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Observaciones).HasMaxLength(255);
            entity.Property(e => e.Oficina).HasMaxLength(255);
            entity.Property(e => e.Proyecto).HasMaxLength(255);
            entity.Property(e => e.Responsable).HasMaxLength(255);
            entity.Property(e => e.Subtipo).HasMaxLength(255);
            entity.Property(e => e.Teléfono).HasMaxLength(255);
            entity.Property(e => e.TipoTeléfono)
                .HasMaxLength(255)
                .HasColumnName("Tipo teléfono");
            entity.Property(e => e.Área).HasMaxLength(255);
            entity.Property(e => e.ÚltimaFFact)
                .HasMaxLength(255)
                .HasColumnName("Última F Fact");
        });

        modelBuilder.Entity<InventarioMovilCuotas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("InventarioMovilCuotas");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.CodigoCuota).HasMaxLength(50);
            entity.Property(e => e.CodigoVario).HasMaxLength(50);
            entity.Property(e => e.DescArea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescVario).HasMaxLength(100);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCuota).HasMaxLength(50);
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.Ush)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USH");
        });

        modelBuilder.Entity<InventarioMovilVario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("InventarioMovilVario");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.CodigoVario).HasMaxLength(50);
            entity.Property(e => e.DescVario).HasMaxLength(100);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaFactura).HasColumnType("smalldatetime");
            entity.Property(e => e.LimiteConsumo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.PrecioLimite)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioMaximo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InventarioTerminales>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodMulti).HasMaxLength(50);
            entity.Property(e => e.CodigoArea).HasMaxLength(50);
            entity.Property(e => e.CodigoU).HasMaxLength(50);
            entity.Property(e => e.Comentario).HasMaxLength(50);
            entity.Property(e => e.ComentarioU).HasMaxLength(50);
            entity.Property(e => e.DatCom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescArea).HasMaxLength(50);
            entity.Property(e => e.DescObs).HasMaxLength(50);
            entity.Property(e => e.DescripcionU).HasMaxLength(50);
            entity.Property(e => e.Direccion).HasMaxLength(50);
            entity.Property(e => e.Empleado).HasMaxLength(50);
            entity.Property(e => e.Empresa).HasMaxLength(50);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.EstadoFm)
                .HasMaxLength(50)
                .HasColumnName("EstadoFM");
            entity.Property(e => e.EstadoU).HasMaxLength(50);
            entity.Property(e => e.Fecha).HasMaxLength(50);
            entity.Property(e => e.FechaProyecto).HasMaxLength(50);
            entity.Property(e => e.FechaU).HasMaxLength(50);
            entity.Property(e => e.Fvigencia)
                .HasMaxLength(50)
                .HasColumnName("FVigencia");
            entity.Property(e => e.Imei).HasMaxLength(50);
            entity.Property(e => e.InicioGarantia).HasMaxLength(50);
            entity.Property(e => e.Item).HasMaxLength(50);
            entity.Property(e => e.LocNodo).HasMaxLength(50);
            entity.Property(e => e.Marca).HasMaxLength(50);
            entity.Property(e => e.Modelo).HasMaxLength(50);
            entity.Property(e => e.Nextension)
                .HasMaxLength(50)
                .HasColumnName("NExtension");
            entity.Property(e => e.Nserie)
                .HasMaxLength(50)
                .HasColumnName("NSerie");
            entity.Property(e => e.Ntelefono)
                .HasMaxLength(50)
                .HasColumnName("NTelefono");
            entity.Property(e => e.Operador).HasMaxLength(50);
            entity.Property(e => e.Origen).HasMaxLength(50);
            entity.Property(e => e.Proyecto).HasMaxLength(50);
            entity.Property(e => e.Puesto).HasMaxLength(50);
            entity.Property(e => e.Responsable).HasMaxLength(50);
            entity.Property(e => e.Secuencia).HasMaxLength(50);
            entity.Property(e => e.SubTipo).HasMaxLength(50);
            entity.Property(e => e.Tipo).HasMaxLength(50);
            entity.Property(e => e.TipoAparato).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.Tubicacion)
                .HasMaxLength(50)
                .HasColumnName("TUbicacion");
            entity.Property(e => e.Tuso)
                .HasMaxLength(50)
                .HasColumnName("TUso");
        });

        modelBuilder.Entity<InventarioVozCuotasV2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("InventarioVozCuotasV2");

            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodProdConcepFact).HasMaxLength(50);
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasMaxLength(180);
            entity.Property(e => e.Descuento).HasColumnName("descuento");
            entity.Property(e => e.DomicilioTa)
                .HasMaxLength(50)
                .HasColumnName("DomicilioTA");
            entity.Property(e => e.DomicilioTb)
                .HasMaxLength(50)
                .HasColumnName("DomicilioTB");
            entity.Property(e => e.Empresa)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasMaxLength(8);
            entity.Property(e => e.FechaAlta).HasMaxLength(50);
            entity.Property(e => e.FechaBaja).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.PoblacionTa)
                .HasMaxLength(50)
                .HasColumnName("PoblacionTA");
            entity.Property(e => e.PoblacionTb)
                .HasMaxLength(50)
                .HasColumnName("PoblacionTB");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<InventarioVozcuotas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("InventarioVOZCuotas");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodProdConcepFact).HasMaxLength(50);
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.DescConFact).HasMaxLength(180);
            entity.Property(e => e.DescTipoServ).HasMaxLength(180);
            entity.Property(e => e.DomicilioTa)
                .HasMaxLength(50)
                .HasColumnName("DomicilioTA");
            entity.Property(e => e.DomicilioTb)
                .HasMaxLength(50)
                .HasColumnName("DomicilioTB");
            entity.Property(e => e.Empresa)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.FechaFactura).HasColumnType("smalldatetime");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nunidades).HasColumnName("NUnidades");
            entity.Property(e => e.PoblacionTa)
                .HasMaxLength(50)
                .HasColumnName("PoblacionTA");
            entity.Property(e => e.PoblacionTb)
                .HasMaxLength(50)
                .HasColumnName("PoblacionTB");
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<Lineas>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodMulticonex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codMulticonex");
            entity.Property(e => e.Compromiso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Direccion).IsUnicode(false);
            entity.Property(e => e.Distancia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAltaOp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaBajaOp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaVigencia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdCentroFisicoTa).HasColumnName("idCentroFisicoTA");
            entity.Property(e => e.IdCentroFisicoTb).HasColumnName("idCentroFisicoTB");
            entity.Property(e => e.IdFuncional).HasColumnName("idFuncional");
            entity.Property(e => e.IdOperadora).HasColumnName("idOperadora");
            entity.Property(e => e.Limite)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NTelfConex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nTelfConex");
            entity.Property(e => e.Sim)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Subtipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TarifaPdatos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TarifaPvoz)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoServicio).IsUnicode(false);
        });

        modelBuilder.Entity<LineasTelefonoCuotas>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcuerdosMarcoVirtuales).HasColumnName("acuerdosMarcoVirtuales");
            entity.Property(e => e.Cuotas)
                .HasMaxLength(2000)
                .HasColumnName("cuotas");
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("nfactura");
            entity.Property(e => e.Ntelefono)
                .HasMaxLength(50)
                .HasColumnName("ntelefono");
        });

        modelBuilder.Entity<LlamadasRdInteligente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LlamadasRdInteligente");

            entity.Property(e => e.Empresa)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
        });

        modelBuilder.Entity<MantCuotasCargos>(entity =>
        {
            entity.HasKey(e => new { e.IdOperadora, e.Codigo, e.IdEmpresa });

            entity.Property(e => e.IdOperadora).HasColumnName("idOperadora");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.AgrupaConcepto)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodTipoServicio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoExt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FechaFin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Periodicidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vigencia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<MantDesPromoParametros>(entity =>
        {
            entity.HasKey(e => e.IdDesPromoParametros);

            entity.ToTable("MantDesPromo_Parametros");

            entity.Property(e => e.IdDesPromoParametros).HasColumnName("IdDesPromo_Parametros");
            entity.Property(e => e.CodigoDescPromo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoParametro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.Operadora)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MantDescPromo>(entity =>
        {
            entity.HasKey(e => new { e.IdOperadora, e.Codigo, e.IdEmpresa });

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.AgrupaConcepto)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Inicio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoAsociacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MantMensaje>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodigoOperadora)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoTipoMensaje)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.Precio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RangoDesde)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RangoHasta)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Mes>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodMes)
                .HasMaxLength(2)
                .HasColumnName("cod_mes");
            entity.Property(e => e.DescMes)
                .HasMaxLength(10)
                .HasColumnName("desc_mes");
        });

        modelBuilder.Entity<MovilCosteporLinea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MovilCosteporLinea");

            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.Cuota).HasColumnName("cuota");
            entity.Property(e => e.Descuentos).HasColumnName("descuentos");
            entity.Property(e => e.FechaFactura).HasColumnType("smalldatetime");
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.Promocion).HasColumnName("promocion");
            entity.Property(e => e.PromocionDto).HasColumnName("promocionDto");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Varios).HasColumnName("varios");
        });

        modelBuilder.Entity<MovilCuotasyVarios>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MovilCuotasyVarios");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.CodigoVario).HasMaxLength(50);
            entity.Property(e => e.DescVario).HasMaxLength(100);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCuota).HasMaxLength(50);
            entity.Property(e => e.DescuentoCuotas).HasMaxLength(50);
            entity.Property(e => e.DescuentoServicio).HasMaxLength(50);
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.ImporteVario).HasMaxLength(50);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
        });

        modelBuilder.Entity<MovilProyecto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MovilProyecto");

            entity.Property(e => e.Annio).HasColumnName("annio");
            entity.Property(e => e.Cif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIF");
            entity.Property(e => e.DescArea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpMovil).HasColumnName("impMovil");
            entity.Property(e => e.Mes)
                .HasMaxLength(30)
                .HasColumnName("mes");
            entity.Property(e => e.NTelfConex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nTelfConex");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TipoLinea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoProyecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ush)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USH");
        });

        modelBuilder.Entity<MovilResumenTipoTrafico>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MovilResumenTipoTrafico");

            entity.Property(e => e.FechaFactura).HasColumnType("smalldatetime");
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.StrDescGrupoTrafico).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
            entity.Property(e => e.UnidadMedida).HasMaxLength(50);
        });

        modelBuilder.Entity<MovilfechFactNum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MOVILFechFactNum");

            entity.Property(e => e.Annio).HasColumnName("annio");
            entity.Property(e => e.FechFactura).HasMaxLength(50);
            entity.Property(e => e.Mes)
                .HasMaxLength(30)
                .HasColumnName("mes");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
        });

        modelBuilder.Entity<MovistarDetalleLlamadas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MovistarDetalleLlamadas");

            entity.Property(e => e.Cantmedidaoriginada)
                .HasMaxLength(4000)
                .HasColumnName("CANTMEDIDAORIGINADA");
            entity.Property(e => e.Cantmedidarecibida)
                .HasMaxLength(4000)
                .HasColumnName("CANTMEDIDARECIBIDA");
            entity.Property(e => e.Coddestino)
                .HasMaxLength(50)
                .HasColumnName("CODDESTINO");
            entity.Property(e => e.Codllamada)
                .HasMaxLength(50)
                .HasColumnName("CODLLAMADA");
            entity.Property(e => e.Codtrafico)
                .HasMaxLength(50)
                .HasColumnName("CODTRAFICO");
            entity.Property(e => e.Dia).HasMaxLength(2);
            entity.Property(e => e.Fecha)
                .HasMaxLength(5)
                .HasColumnName("FECHA");
            entity.Property(e => e.Franja)
                .HasMaxLength(50)
                .HasColumnName("FRANJA");
            entity.Property(e => e.Horainicio)
                .HasMaxLength(8)
                .HasColumnName("HORAINICIO");
            entity.Property(e => e.Importe)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.Importedatos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IMPORTEDATOS");
            entity.Property(e => e.Mes).HasMaxLength(2);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nllamado)
                .HasMaxLength(50)
                .HasColumnName("NLlamado");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.Operadordestino)
                .HasMaxLength(50)
                .HasColumnName("OPERADORDESTINO");
            entity.Property(e => e.Operadororigen).HasColumnName("OPERADORORIGEN");
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .HasColumnName("TARIFA");
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
            entity.Property(e => e.Tipodestino)
                .HasMaxLength(50)
                .HasColumnName("TIPODESTINO");
            entity.Property(e => e.Tipollamada)
                .HasMaxLength(50)
                .HasColumnName("TIPOLLAMADA");
            entity.Property(e => e.Unidadmedida)
                .HasMaxLength(50)
                .HasColumnName("UNIDADMEDIDA");
        });

        modelBuilder.Entity<NivelAsociacion>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<NlineasCorpTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NLineasCorpTotal");

            entity.Property(e => e.Ntelefono).HasMaxLength(50);
        });

        modelBuilder.Entity<NlineasMovil>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NLineasMovil");

            entity.Property(e => e.Bimponible).HasColumnName("BImponible");
            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.CodFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codFactura");
            entity.Property(e => e.Cuota).HasColumnName("cuota");
            entity.Property(e => e.Descuentos).HasColumnName("descuentos");
            entity.Property(e => e.Empresa)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.FechaFactura).HasColumnType("smalldatetime");
            entity.Property(e => e.Impuesto).HasMaxLength(50);
            entity.Property(e => e.LineasMoviles).HasColumnName("lineasMoviles");
            entity.Property(e => e.Tipo).HasMaxLength(50);
            entity.Property(e => e.Varios).HasColumnName("varios");
        });

        modelBuilder.Entity<NlineasVoz>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NLineasVoz");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasMaxLength(8)
                .HasColumnName("fecha");
            entity.Property(e => e.Importe).HasColumnName("importe");
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<NllamadasCorporativaImporte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NLlamadasCorporativaImporte");

            entity.Property(e => e.Empresa)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("empresa");
            entity.Property(e => e.FacturaInterna).HasMaxLength(50);
            entity.Property(e => e.FechaFactura).HasColumnType("smalldatetime");
            entity.Property(e => e.Importe).HasColumnName("importe");
            entity.Property(e => e.TipoLlamadas)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.TipoTrafico).HasMaxLength(180);
        });

        modelBuilder.Entity<NllamadasTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NLlamadasTotal");

            entity.Property(e => e.Empresa)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("empresa");
            entity.Property(e => e.FacturaInterna).HasMaxLength(50);
            entity.Property(e => e.FechaFactura).HasColumnType("smalldatetime");
            entity.Property(e => e.Imp).HasColumnName("imp");
            entity.Property(e => e.Nsolicitado)
                .HasMaxLength(50)
                .HasColumnName("NSolicitado");
            entity.Property(e => e.NumeroLlamado)
                .HasMaxLength(50)
                .HasColumnName("NumeroLLamado");
            entity.Property(e => e.TipoLlamadas)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.TipoTrafico).HasMaxLength(180);
        });

        modelBuilder.Entity<Operador>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Organigrama>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BusinessUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("business_unit");
            entity.Property(e => e.Calle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Deptid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deptid");
            entity.Property(e => e.DescCargo)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.DescDepartamento)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.DescPosicion)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("email");
            entity.Property(e => e.EmplidDelegate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emplid_delegate");
            entity.Property(e => e.FfinContrato)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.IdCargo)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("idCargo");
            entity.Property(e => e.IdDepartamento)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("idDepartamento");
            entity.Property(e => e.IdEmpleado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idEmpleado");
            entity.Property(e => e.IdGrupo).HasColumnName("idGrupo");
            entity.Property(e => e.IdPosicion)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("idPosicion");
            entity.Property(e => e.Localidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nif)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnidadNegocio)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UsuarioRed)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Parametros>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tabla)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Presupuestos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Año)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DatosImporte)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DatosLineas)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empresa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FijoImporte)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FijoLineas)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.McorporativoImporte)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MCorporativoImporte");
            entity.Property(e => e.McorporativoLineas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MCorporativoLineas");
            entity.Property(e => e.MdatosImporte)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MDatosImporte");
            entity.Property(e => e.MdatosLineas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MDatosLineas");
            entity.Property(e => e.MinternacionalImporte)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MInternacionalImporte");
            entity.Property(e => e.MinternacionalLineas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MInternacionalLineas");
            entity.Property(e => e.MmensajesImporte)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MMensajesImporte");
            entity.Property(e => e.MmensajesLineas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MMensajesLineas");
            entity.Property(e => e.MnoCorporativoImporte)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MNoCorporativoImporte");
            entity.Property(e => e.MnoCorporativoLineas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MNoCorporativoLineas");
            entity.Property(e => e.MrestoImporte)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MRestoImporte");
            entity.Property(e => e.MrestoLineas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MRestoLineas");
        });

        modelBuilder.Entity<ProvAlbaranes>(entity =>
        {
            entity.HasKey(e => e.IdAlb);

            entity.ToTable("prov_Albaranes");

            entity.Property(e => e.IdAlb)
                .ValueGeneratedNever()
                .HasColumnName("id_alb");
            entity.Property(e => e.AcusereciboAlb).HasColumnName("acuserecibo_alb");
            entity.Property(e => e.AgenciaAlb)
                .HasMaxLength(250)
                .HasColumnName("agencia_alb");
            entity.Property(e => e.ContactodestinoAlb)
                .HasMaxLength(250)
                .HasColumnName("contactodestino_alb");
            entity.Property(e => e.CpdestinoAlb)
                .HasMaxLength(5)
                .HasColumnName("cpdestino_alb");
            entity.Property(e => e.DirdestinoAlb)
                .HasMaxLength(250)
                .HasColumnName("dirdestino_alb");
            entity.Property(e => e.EmaildestinoAlb)
                .HasMaxLength(250)
                .HasColumnName("emaildestino_alb");
            entity.Property(e => e.EstadoAlb)
                .HasMaxLength(25)
                .HasColumnName("estado_alb");
            entity.Property(e => e.FechaAlb)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alb");
            entity.Property(e => e.FechaestadoAlb)
                .HasColumnType("datetime")
                .HasColumnName("fechaestado_alb");
            entity.Property(e => e.IdadminCreadoporAlb).HasColumnName("idadmin_creadopor_alb");
            entity.Property(e => e.IdclienteAlb).HasColumnName("idcliente_alb");
            entity.Property(e => e.NifusuarioAlb)
                .HasMaxLength(15)
                .HasColumnName("nifusuario_alb");
            entity.Property(e => e.NomdestinoAlb)
                .HasMaxLength(250)
                .HasColumnName("nomdestino_alb");
            entity.Property(e => e.OtrosAlb).HasColumnName("otros_alb");
            entity.Property(e => e.PdebidosAlb).HasColumnName("pdebidos_alb");
            entity.Property(e => e.PobldestinoAlb)
                .HasMaxLength(150)
                .HasColumnName("pobldestino_alb");
            entity.Property(e => e.ProvdestinoAlb)
                .HasMaxLength(150)
                .HasColumnName("provdestino_alb");
            entity.Property(e => e.RefexternaAlb)
                .HasMaxLength(50)
                .HasColumnName("refexterna_alb");
            entity.Property(e => e.TeldestinoAlb)
                .HasMaxLength(15)
                .HasColumnName("teldestino_alb");
            entity.Property(e => e.TipodestinoAlb)
                .HasMaxLength(15)
                .HasColumnName("tipodestino_alb");
        });

        modelBuilder.Entity<ProvAtributos>(entity =>
        {
            entity.HasKey(e => e.Idatributo);

            entity.ToTable("prov_Atributos");

            entity.Property(e => e.Idatributo).HasColumnName("IDATRIBUTO");
            entity.Property(e => e.CategoriaAtrb)
                .HasMaxLength(25)
                .HasColumnName("CATEGORIA_ATRB");
            entity.Property(e => e.CodfacturacionAtrb)
                .HasMaxLength(25)
                .HasColumnName("CODFACTURACION_ATRB");
            entity.Property(e => e.CodigoAtrb)
                .HasMaxLength(15)
                .HasColumnName("CODIGO_ATRB");
            entity.Property(e => e.DescripcionAtrb).HasColumnName("DESCRIPCION_ATRB");
            entity.Property(e => e.EmisorAtrb)
                .HasMaxLength(5)
                .HasColumnName("EMISOR_ATRB");
            entity.Property(e => e.EstadoAtrb)
                .HasMaxLength(15)
                .HasColumnName("ESTADO_ATRB");
            entity.Property(e => e.FaltaAtrb)
                .HasColumnType("datetime")
                .HasColumnName("FALTA_ATRB");
            entity.Property(e => e.FestadoAtrb)
                .HasColumnType("datetime")
                .HasColumnName("FESTADO_ATRB");
            entity.Property(e => e.LiteralAtrb)
                .HasMaxLength(100)
                .HasColumnName("LITERAL_ATRB");
            entity.Property(e => e.LiteralasociadoAtrb)
                .HasMaxLength(200)
                .HasColumnName("LITERALASOCIADO_ATRB");
            entity.Property(e => e.Nivel4editarAtrb).HasColumnName("NIVEL4EDITAR_ATRB");
            entity.Property(e => e.NivelAtrb)
                .HasMaxLength(15)
                .HasColumnName("NIVEL_ATRB");
            entity.Property(e => e.ObligatorioAtrb).HasColumnName("OBLIGATORIO_ATRB");
            entity.Property(e => e.Param1Atrb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PARAM1_ATRB");
            entity.Property(e => e.Param2Atrb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PARAM2_ATRB");
            entity.Property(e => e.Param3Atrb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PARAM3_ATRB");
            entity.Property(e => e.PermiterepAtrb).HasColumnName("PERMITEREP_ATRB");
            entity.Property(e => e.ProrrateoAtrb).HasColumnName("PRORRATEO_ATRB");
            entity.Property(e => e.TipoAtrb)
                .HasMaxLength(25)
                .HasColumnName("TIPO_ATRB");
            entity.Property(e => e.TraficoincluidoAtrb)
                .HasMaxLength(15)
                .HasColumnName("TRAFICOINCLUIDO_ATRB");
            entity.Property(e => e.ValorAtrb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VALOR_ATRB");
        });

        modelBuilder.Entity<ProvBaseCatalogo>(entity =>
        {
            entity.HasKey(e => new { e.IdCat, e.IdTerm });

            entity.ToTable("prov_BaseCatalogo");

            entity.Property(e => e.IdCat).HasColumnName("ID_CAT");
            entity.Property(e => e.IdTerm).HasColumnName("ID_TERM");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ALTA");
        });

        modelBuilder.Entity<ProvCatPrdconvergentes>(entity =>
        {
            entity.HasKey(e => e.IdCatpc);

            entity.ToTable("PROV_CAT_PRDCONVERGENTES");

            entity.Property(e => e.IdCatpc).HasColumnName("ID_CATPC");
            entity.Property(e => e.AtributosAltaCpc)
                .HasMaxLength(1000)
                .HasColumnName("ATRIBUTOS_ALTA_CPC");
            entity.Property(e => e.CodigoCatpc)
                .HasMaxLength(50)
                .HasColumnName("CODIGO_CATPC");
            entity.Property(e => e.ComentariosInternosCpc)
                .HasMaxLength(255)
                .HasColumnName("COMENTARIOS_INTERNOS_CPC");
            entity.Property(e => e.DescripcionCpc)
                .HasMaxLength(500)
                .HasColumnName("DESCRIPCION_CPC");
            entity.Property(e => e.EstadoCpc)
                .HasMaxLength(25)
                .HasColumnName("ESTADO_CPC");
            entity.Property(e => e.FaltaCpc)
                .HasColumnType("datetime")
                .HasColumnName("FALTA_CPC");
            entity.Property(e => e.FbajaCpc)
                .HasColumnType("datetime")
                .HasColumnName("FBAJA_CPC");
            entity.Property(e => e.FestadoCpc)
                .HasColumnType("datetime")
                .HasColumnName("FESTADO_CPC");
            entity.Property(e => e.Idcolectivo).HasColumnName("IDCOLECTIVO");
            entity.Property(e => e.NombreCpc)
                .HasMaxLength(100)
                .HasColumnName("NOMBRE_CPC");
            entity.Property(e => e.NumSubproductosCpc).HasColumnName("NUM_SUBPRODUCTOS_CPC");
            entity.Property(e => e.PenalizacionCpc).HasColumnName("PENALIZACION_CPC");
            entity.Property(e => e.Perfilusuario)
                .HasMaxLength(1)
                .HasColumnName("PERFILUSUARIO");
            entity.Property(e => e.PlanprincipalCpc)
                .HasMaxLength(100)
                .HasColumnName("PLANPRINCIPAL_CPC");
            entity.Property(e => e.PrecioCpc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRECIO_CPC");
            entity.Property(e => e.SubproductosCpc)
                .HasMaxLength(1000)
                .HasColumnName("SUBPRODUCTOS_CPC");
            entity.Property(e => e.SubvencionCpc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SUBVENCION_CPC");
        });

        modelBuilder.Entity<ProvCatalogos>(entity =>
        {
            entity.HasKey(e => e.IdCat);

            entity.ToTable("prov_Catalogos");

            entity.Property(e => e.IdCat)
                .ValueGeneratedNever()
                .HasColumnName("ID_CAT");
            entity.Property(e => e.Codoperador).HasColumnName("CODOPERADOR");
            entity.Property(e => e.CosteAdicional)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("COSTE_ADICIONAL");
            entity.Property(e => e.EstadoCat)
                .HasMaxLength(25)
                .HasColumnName("ESTADO_CAT");
            entity.Property(e => e.FechaaltaCat)
                .HasColumnType("datetime")
                .HasColumnName("FECHAALTA_CAT");
            entity.Property(e => e.FechaestadoCat)
                .HasColumnType("datetime")
                .HasColumnName("FECHAESTADO_CAT");
            entity.Property(e => e.Franquicia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FRANQUICIA");
            entity.Property(e => e.InfoAdicional).HasColumnName("INFO_ADICIONAL");
            entity.Property(e => e.Informecatalogo)
                .HasMaxLength(50)
                .HasColumnName("INFORMECATALOGO");
            entity.Property(e => e.NombreCat)
                .HasMaxLength(150)
                .HasColumnName("NOMBRE_CAT");
        });

        modelBuilder.Entity<ProvColectivos>(entity =>
        {
            entity.HasKey(e => e.Cif)
                .HasName("aaaaaprov_Colectivos_PK")
                .IsClustered(false);

            entity.ToTable("prov_Colectivos");

            entity.Property(e => e.Cif)
                .HasMaxLength(15)
                .HasColumnName("cif");
            entity.Property(e => e.Cp).HasMaxLength(5);
            entity.Property(e => e.Descripcion).HasColumnType("ntext");
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.DniAdminLegal)
                .HasMaxLength(9)
                .HasColumnName("dni_admin_legal");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.EstadoSincro)
                .HasMaxLength(50)
                .HasColumnName("Estado_sincro");
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaEstadoSincro)
                .HasColumnType("datetime")
                .HasColumnName("FechaEstado_sincro");
            entity.Property(e => e.FechaModif).HasColumnType("datetime");
            entity.Property(e => e.Franquicia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdGrupo).HasColumnName("idGrupo");
            entity.Property(e => e.IdServidor).HasColumnName("id_servidor");
            entity.Property(e => e.MargenColectivo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NombreAdminLegal)
                .HasMaxLength(255)
                .HasColumnName("nombre_admin_legal");
            entity.Property(e => e.NombreBanco).HasMaxLength(50);
            entity.Property(e => e.NumCuenta).HasMaxLength(50);
            entity.Property(e => e.Poblacion).HasMaxLength(100);
            entity.Property(e => e.Provincia).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(50);
        });

        modelBuilder.Entity<ProvCompromisosLinea>(entity =>
        {
            entity.ToTable("prov_CompromisosLinea");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.Emisor).HasMaxLength(10);
            entity.Property(e => e.Estado).HasMaxLength(15);
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaHasta).HasColumnType("datetime");
            entity.Property(e => e.Idcolectivo).HasColumnName("IDColectivo");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Modo).HasMaxLength(1);
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.NumTelefono).HasMaxLength(25);
        });

        modelBuilder.Entity<ProvDocumentosCt>(entity =>
        {
            entity.HasKey(e => e.IdDocumento);

            entity.ToTable("prov_DocumentosCT");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.NombreFichero).HasMaxLength(250);
            entity.Property(e => e.NumTelefono).HasMaxLength(9);
            entity.Property(e => e.RutaServidor).HasMaxLength(1000);
        });

        modelBuilder.Entity<ProvFicherosAdjuntos>(entity =>
        {
            entity.HasKey(e => e.IdFichero);

            entity.ToTable("prov_FicherosAdjuntos");

            entity.Property(e => e.IdFichero).HasColumnName("idFichero");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.IdLinea).HasColumnName("idLinea");
            entity.Property(e => e.IdPeticion).HasColumnName("idPeticion");
            entity.Property(e => e.NombreFichero)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RutaServidor)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProvFiltrosBusqueda>(entity =>
        {
            entity.ToTable("prov_FiltrosBusqueda");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ambito).HasMaxLength(50);
        });

        modelBuilder.Entity<ProvHistPeticiones>(entity =>
        {
            entity.HasKey(e => e.IdHistorial);

            entity.ToTable("prov_HistPeticiones");

            entity.Property(e => e.IdHistorial).HasColumnName("idHistorial");
            entity.Property(e => e.Comentario)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.FechaModif).HasColumnType("datetime");
            entity.Property(e => e.IdAdminHis).HasColumnName("idAdminHIS");
            entity.Property(e => e.IdPeticion).HasColumnName("idPeticion");
        });

        modelBuilder.Entity<ProvLineas>(entity =>
        {
            entity.HasKey(e => new { e.NumTelefono, e.IdCliente })
                .HasName("aaaaaprov_Lineas_prueba_PK")
                .IsClustered(false);

            entity.ToTable("prov_lineas");

            entity.Property(e => e.NumTelefono).HasMaxLength(50);
            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.AccionesPosActivacion).HasMaxLength(1000);
            entity.Property(e => e.CodigosEstado)
                .HasMaxLength(255)
                .HasColumnName("codigosEstado");
            entity.Property(e => e.Comentarios).HasMaxLength(4000);
            entity.Property(e => e.CosteDatos).HasColumnName("costeDatos");
            entity.Property(e => e.CosteTerminal)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("costeTerminal");
            entity.Property(e => e.CosteTerminalPvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("costeTerminalPVP");
            entity.Property(e => e.CuentaMaestraFibra)
                .HasMaxLength(25)
                .HasColumnName("cuentaMaestraFibra");
            entity.Property(e => e.Datos).HasColumnName("datos");
            entity.Property(e => e.EsPcPrincipal).HasColumnName("ES_PC_PRINCIPAL");
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.EstadoSincro)
                .HasMaxLength(50)
                .HasColumnName("Estado_sincro");
            entity.Property(e => e.Extension)
                .HasMaxLength(6)
                .HasColumnName("extension");
            entity.Property(e => e.FechaActivacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaActivacion");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaEntregaTerminal).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fechaEstado");
            entity.Property(e => e.FechaEstadoSincro)
                .HasColumnType("datetime")
                .HasColumnName("FechaEstado_sincro");
            entity.Property(e => e.FechaPublicacionTerminal).HasColumnType("datetime");
            entity.Property(e => e.FechaVc)
                .HasColumnType("datetime")
                .HasColumnName("fechaVC");
            entity.Property(e => e.Franquicia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FranquiciaMax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Fumr)
                .HasMaxLength(25)
                .HasColumnName("FUMR");
            entity.Property(e => e.IdAdmin).HasColumnName("idAdmin");
            entity.Property(e => e.IdAutorizadoFibra).HasColumnName("idAutorizadoFibra");
            entity.Property(e => e.IdCatpc).HasColumnName("ID_CATPC");
            entity.Property(e => e.IdDocumentoCt).HasColumnName("IdDocumentoCT");
            entity.Property(e => e.IdLineaAsociatel)
                .HasMaxLength(25)
                .HasColumnName("idLineaAsociatel");
            entity.Property(e => e.IdLineaProlin)
                .ValueGeneratedOnAdd()
                .HasColumnName("idLineaProlin");
            entity.Property(e => e.IdLineaVinculada).HasColumnName("idLineaVinculada");
            entity.Property(e => e.IdNumpc).HasColumnName("ID_NUMPC");
            entity.Property(e => e.IdServidor).HasColumnName("id_servidor");
            entity.Property(e => e.IdfinanTf).HasColumnName("idfinan_TF");
            entity.Property(e => e.Imei)
                .HasMaxLength(20)
                .HasColumnName("imei");
            entity.Property(e => e.ImeiTermActual).HasMaxLength(25);
            entity.Property(e => e.ImporteFianza).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImportePendiente).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InfoAdicional).HasColumnType("ntext");
            entity.Property(e => e.LimiteConsumo).HasMaxLength(50);
            entity.Property(e => e.MotivoIncidencia)
                .HasMaxLength(50)
                .HasColumnName("MOTIVO_INCIDENCIA");
            entity.Property(e => e.NifTitular)
                .HasMaxLength(13)
                .HasColumnName("nifTitular");
            entity.Property(e => e.NifUsuario)
                .HasMaxLength(13)
                .HasColumnName("nifUsuario");
            entity.Property(e => e.NumContratoTrastienda)
                .HasMaxLength(25)
                .HasColumnName("numContratoTrastienda");
            entity.Property(e => e.NumVf)
                .HasMaxLength(10)
                .HasColumnName("numVF");
            entity.Property(e => e.Operador).HasMaxLength(50);
            entity.Property(e => e.OrdenDeLista).HasColumnName("ordenDeLista");
            entity.Property(e => e.Origen).HasMaxLength(50);
            entity.Property(e => e.Otros).HasColumnName("otros");
            entity.Property(e => e.OtrosServicios)
                .HasMaxLength(1000)
                .HasColumnName("otrosServicios");
            entity.Property(e => e.Pin)
                .HasMaxLength(4)
                .HasColumnName("pin");
            entity.Property(e => e.Puk)
                .HasMaxLength(8)
                .HasColumnName("puk");
            entity.Property(e => e.Restricciones)
                .HasMaxLength(1000)
                .HasColumnName("restricciones");
            entity.Property(e => e.SimActual)
                .HasMaxLength(25)
                .HasColumnName("simActual");
            entity.Property(e => e.SimDonante)
                .HasMaxLength(25)
                .HasColumnName("simDonante");
            entity.Property(e => e.TarifaDatos)
                .HasMaxLength(255)
                .HasColumnName("tarifaDatos");
            entity.Property(e => e.Terminal)
                .HasMaxLength(255)
                .HasColumnName("terminal");
            entity.Property(e => e.TerminalActual).HasMaxLength(255);
            entity.Property(e => e.TerminalFinanciado).HasColumnName("terminalFinanciado");
            entity.Property(e => e.Vodafonefijo).HasColumnName("vodafonefijo");
        });

        modelBuilder.Entity<ProvLineasAlb>(entity =>
        {
            entity.HasKey(e => e.IdLineaalb).HasName("PK_prov_LineasAlb_1");

            entity.ToTable("prov_LineasAlb");

            entity.Property(e => e.IdLineaalb).HasColumnName("id_lineaalb");
            entity.Property(e => e.IdAlb).HasColumnName("id_alb");
            entity.Property(e => e.IdOrdenPosventa).HasColumnName("id_orden_posventa");
            entity.Property(e => e.IdclienteLinea).HasColumnName("idcliente_linea");
            entity.Property(e => e.ImeiAlb)
                .HasMaxLength(25)
                .HasColumnName("imei_alb");
            entity.Property(e => e.NumTelefonoAlb)
                .HasMaxLength(50)
                .HasColumnName("numTelefono_alb");
            entity.Property(e => e.SimAlb)
                .HasMaxLength(25)
                .HasColumnName("sim_alb");
            entity.Property(e => e.TerminalAlb)
                .HasMaxLength(255)
                .HasColumnName("terminal_alb");
        });

        modelBuilder.Entity<ProvMargenHbd>(entity =>
        {
            entity.HasKey(e => e.Idmargen);

            entity.ToTable("prov_margenHbd");

            entity.Property(e => e.Idmargen).HasColumnName("idmargen");
            entity.Property(e => e.Codtarifa)
                .HasMaxLength(15)
                .HasColumnName("codtarifa");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(15)
                .HasColumnName("estado");
            entity.Property(e => e.Fechaalta)
                .HasColumnType("datetime")
                .HasColumnName("fechaalta");
            entity.Property(e => e.Fechaestado)
                .HasColumnType("datetime")
                .HasColumnName("fechaestado");
            entity.Property(e => e.Idcolectivo).HasColumnName("idcolectivo");
            entity.Property(e => e.Limiteinf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("limiteinf");
            entity.Property(e => e.Limitesup)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("limitesup");
            entity.Property(e => e.LiteralHbd)
                .HasMaxLength(100)
                .HasColumnName("literalHbd");
            entity.Property(e => e.MargenHbd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("margenHbd");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<ProvModosFinanciacionTerminales>(entity =>
        {
            entity.HasKey(e => e.IdMft);

            entity.ToTable("prov_ModosFinanciacionTerminales");

            entity.Property(e => e.IdMft).HasColumnName("ID_MFT");
            entity.Property(e => e.CodigoMft)
                .HasMaxLength(15)
                .HasColumnName("CODIGO_MFT");
            entity.Property(e => e.ComisionMft)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("COMISION_MFT");
            entity.Property(e => e.DescripcionMft)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPCION_MFT");
            entity.Property(e => e.EstadoMft)
                .HasMaxLength(15)
                .HasColumnName("ESTADO_MFT");
            entity.Property(e => e.FaltaMft)
                .HasColumnType("datetime")
                .HasColumnName("FALTA_MFT");
            entity.Property(e => e.FestadoMft)
                .HasColumnType("datetime")
                .HasColumnName("FESTADO_MFT");
            entity.Property(e => e.Idcolectivo).HasColumnName("IDCOLECTIVO");
            entity.Property(e => e.ImportemaxMft)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTEMAX_MFT");
            entity.Property(e => e.ImporteminMft)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTEMIN_MFT");
            entity.Property(e => e.LiteralMft)
                .HasMaxLength(150)
                .HasColumnName("LITERAL_MFT");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.PlazosMft).HasColumnName("PLAZOS_MFT");
        });

        modelBuilder.Entity<ProvPeticionesIncidencias>(entity =>
        {
            entity.HasKey(e => e.IdPeticion);

            entity.ToTable("prov_PeticionesIncidencias");

            entity.Property(e => e.IdPeticion).HasColumnName("idPeticion");
            entity.Property(e => e.Asunto).HasMaxLength(250);
            entity.Property(e => e.ComentarioCierre)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.IdAdminPet).HasColumnName("idAdminPET");
            entity.Property(e => e.IdClientePet).HasColumnName("idClientePET");
            entity.Property(e => e.IdLineaProlin).HasColumnName("idLineaProlin");
            entity.Property(e => e.IdOperadorAsignado).HasColumnName("idOperadorAsignado");
            entity.Property(e => e.IdUsuarioProlin).HasColumnName("idUsuarioProlin");
            entity.Property(e => e.Prioridad)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProvPrdconvergentesEncurso>(entity =>
        {
            entity.HasKey(e => e.IdNumpc);

            entity.ToTable("PROV_PRDCONVERGENTES_ENCURSO");

            entity.Property(e => e.IdNumpc).HasColumnName("ID_NUMPC");
            entity.Property(e => e.CodigoCatpc)
                .HasMaxLength(50)
                .HasColumnName("CODIGO_CATPC");
            entity.Property(e => e.EstadoPc)
                .HasMaxLength(25)
                .HasColumnName("ESTADO_PC");
            entity.Property(e => e.FaltaPc)
                .HasColumnType("datetime")
                .HasColumnName("FALTA_PC");
            entity.Property(e => e.FcompletadoPc)
                .HasColumnType("datetime")
                .HasColumnName("FCOMPLETADO_PC");
            entity.Property(e => e.FestadoPc)
                .HasColumnType("datetime")
                .HasColumnName("FESTADO_PC");
            entity.Property(e => e.IdCatpc).HasColumnName("ID_CATPC");
            entity.Property(e => e.Idcolectivo).HasColumnName("IDCOLECTIVO");
            entity.Property(e => e.Perfilusuario)
                .HasMaxLength(1)
                .HasColumnName("PERFILUSUARIO");
        });

        modelBuilder.Entity<ProvPuntosPromo1>(entity =>
        {
            entity.HasKey(e => e.Idoperacion);

            entity.ToTable("prov_puntos_promo1");

            entity.Property(e => e.Idoperacion).HasColumnName("IDOperacion");
            entity.Property(e => e.Comentario).HasMaxLength(255);
            entity.Property(e => e.FechaOperacion).HasColumnType("datetime");
            entity.Property(e => e.Idcolectivo).HasColumnName("IDColectivo");
            entity.Property(e => e.NifUsuario)
                .HasMaxLength(9)
                .HasColumnName("NIF_Usuario");
        });

        modelBuilder.Entity<ProvRcatalogoTerminal>(entity =>
        {
            entity.ToTable("prov_RCatalogo_Terminal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodTarifa).HasMaxLength(25);
            entity.Property(e => e.CodtarifaOperador)
                .HasMaxLength(25)
                .HasColumnName("codtarifa_operador");
            entity.Property(e => e.CuentaVf)
                .HasMaxLength(15)
                .HasColumnName("cuenta_vf");
            entity.Property(e => e.DescTarifa).HasMaxLength(100);
            entity.Property(e => e.IdCat).HasColumnName("ID_CAT");
            entity.Property(e => e.IdColectivo).HasColumnName("ID_COLECTIVO");
            entity.Property(e => e.IdTerm).HasColumnName("ID_TERM");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.PrecioCosteTarifa).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioCosteTerminal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioCosteTerminalUpload).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioNetoTarifa).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioPvpterminal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PrecioPVPTerminal");
            entity.Property(e => e.PrecioPvpterminalUpload)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PrecioPVPTerminalUpload");
            entity.Property(e => e.VolDatosTarifa).HasMaxLength(50);
        });

        modelBuilder.Entity<ProvReferentes>(entity =>
        {
            entity.HasKey(e => new { e.NifUsuarioNuevo, e.IdcolectivoUsuarioNuevo });

            entity.ToTable("prov_referentes");

            entity.Property(e => e.NifUsuarioNuevo)
                .HasMaxLength(9)
                .HasColumnName("NIF_UsuarioNuevo");
            entity.Property(e => e.IdcolectivoUsuarioNuevo).HasColumnName("IDColectivo_UsuarioNuevo");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.IdcolectivoUsuarioReferente).HasColumnName("IDColectivo_UsuarioReferente");
            entity.Property(e => e.NifUsuarioReferente)
                .HasMaxLength(9)
                .HasColumnName("NIF_UsuarioReferente");
        });

        modelBuilder.Entity<ProvRterminalTdatos>(entity =>
        {
            entity.HasKey(e => new { e.IdTerm, e.CodTarifa });

            entity.ToTable("prov_RTerminal_TDatos");

            entity.Property(e => e.IdTerm).HasColumnName("ID_TERM");
            entity.Property(e => e.CodTarifa)
                .HasMaxLength(15)
                .HasColumnName("COD_TARIFA");
        });

        modelBuilder.Entity<ProvTarifasDatos>(entity =>
        {
            entity.HasKey(e => e.IdTarifaDatos);

            entity.ToTable("prov_TarifasDatos");

            entity.Property(e => e.IdTarifaDatos).HasColumnName("idTarifaDatos");
            entity.Property(e => e.AtrboblBaja)
                .HasMaxLength(150)
                .HasColumnName("ATRBOBL_BAJA");
            entity.Property(e => e.AtrbopcAlta)
                .HasMaxLength(200)
                .HasColumnName("ATRBOPC_ALTA");
            entity.Property(e => e.Categoriaterm)
                .HasMaxLength(1)
                .HasColumnName("categoriaterm");
            entity.Property(e => e.CodTarifa)
                .HasMaxLength(25)
                .HasColumnName("codTarifa");
            entity.Property(e => e.CodtarifaOperador)
                .HasMaxLength(50)
                .HasColumnName("codtarifa_operador");
            entity.Property(e => e.CuentaVf)
                .HasMaxLength(15)
                .HasColumnName("cuenta_vf");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.DtoOperador)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("dtoOperador");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .HasColumnName("estado");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.IdOperador).HasColumnName("idOperador");
            entity.Property(e => e.LiteralAsociado)
                .HasMaxLength(200)
                .HasColumnName("literalAsociado");
            entity.Property(e => e.MaxLineasAdicionales).HasColumnName("maxLineasAdicionales");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.PlanesPreciosPrincipales)
                .HasMaxLength(250)
                .HasColumnName("planesPreciosPrincipales");
            entity.Property(e => e.PrecioBruto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precioBruto");
            entity.Property(e => e.PrecioCoste)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precioCoste");
            entity.Property(e => e.PrecioNeto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precioNeto");
            entity.Property(e => e.ServiciosAdicionales)
                .HasMaxLength(100)
                .HasColumnName("serviciosAdicionales");
            entity.Property(e => e.SubTipo)
                .HasMaxLength(10)
                .HasColumnName("subTipo");
            entity.Property(e => e.SubvencionAlta)
                .HasMaxLength(10)
                .HasColumnName("subvencionAlta");
            entity.Property(e => e.SubvencionUpsell)
                .HasMaxLength(10)
                .HasColumnName("subvencionUpsell");
            entity.Property(e => e.TipoTarifa).HasColumnName("tipoTarifa");
            entity.Property(e => e.VolumenDatos).HasMaxLength(50);
        });

        modelBuilder.Entity<ProvTerminales>(entity =>
        {
            entity.HasKey(e => e.IdTerm);

            entity.ToTable("prov_Terminales");

            entity.Property(e => e.IdTerm)
                .ValueGeneratedNever()
                .HasColumnName("ID_TERM");
            entity.Property(e => e.BluetoothTerm)
                .HasMaxLength(2)
                .HasColumnName("BLUETOOTH_TERM");
            entity.Property(e => e.CamaraTerm)
                .HasMaxLength(25)
                .HasColumnName("CAMARA_TERM");
            entity.Property(e => e.CategoriaTerm)
                .HasMaxLength(1)
                .HasColumnName("CATEGORIA_TERM");
            entity.Property(e => e.Codoperador).HasColumnName("CODOPERADOR");
            entity.Property(e => e.EstadoTerm)
                .HasMaxLength(25)
                .HasColumnName("ESTADO_TERM");
            entity.Property(e => e.FabricanteTerm)
                .HasMaxLength(100)
                .HasColumnName("FABRICANTE_TERM");
            entity.Property(e => e.FechaFinSwapTerm)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_FIN_SWAP_TERM");
            entity.Property(e => e.FechaaltaTerm)
                .HasColumnType("datetime")
                .HasColumnName("FECHAALTA_TERM");
            entity.Property(e => e.FechaestadoTerm)
                .HasColumnType("datetime")
                .HasColumnName("FECHAESTADO_TERM");
            entity.Property(e => e.FijoTerm)
                .HasMaxLength(2)
                .HasColumnName("FIJO_TERM");
            entity.Property(e => e.GamaTerm)
                .HasMaxLength(25)
                .HasColumnName("GAMA_TERM");
            entity.Property(e => e.GpsTerm)
                .HasMaxLength(2)
                .HasColumnName("GPS_TERM");
            entity.Property(e => e.ImagenTerm)
                .HasMaxLength(500)
                .HasColumnName("IMAGEN_TERM");
            entity.Property(e => e.MeminternaTerm)
                .HasMaxLength(25)
                .HasColumnName("MEMINTERNA_TERM");
            entity.Property(e => e.NombreTerm)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE_TERM");
            entity.Property(e => e.ObservacionesTerm)
                .HasMaxLength(1000)
                .HasColumnName("OBSERVACIONES_TERM");
            entity.Property(e => e.PantallaTerm)
                .HasMaxLength(50)
                .HasColumnName("PANTALLA_TERM");
            entity.Property(e => e.PrecioTerm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRECIO_TERM");
            entity.Property(e => e.PrecioTermPe)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRECIO_TERM_PE");
            entity.Property(e => e.ProcesadorTerm)
                .HasMaxLength(50)
                .HasColumnName("PROCESADOR_TERM");
            entity.Property(e => e.RadiofmTerm)
                .HasMaxLength(2)
                .HasColumnName("RADIOFM_TERM");
            entity.Property(e => e.ReferenciaTerm)
                .HasMaxLength(15)
                .HasColumnName("REFERENCIA_TERM");
            entity.Property(e => e.SdTerm)
                .HasMaxLength(25)
                .HasColumnName("SD_TERM");
            entity.Property(e => e.SoTerm)
                .HasMaxLength(25)
                .HasColumnName("SO_TERM");
            entity.Property(e => e.WifiTerm)
                .HasMaxLength(2)
                .HasColumnName("WIFI_TERM");
        });

        modelBuilder.Entity<ProvTerminalesFinanciados>(entity =>
        {
            entity.HasKey(e => e.IdfinanTf);

            entity.ToTable("prov_TerminalesFinanciados");

            entity.Property(e => e.IdfinanTf).HasColumnName("IDFINAN_TF");
            entity.Property(e => e.CodigoMft)
                .HasMaxLength(15)
                .HasColumnName("CODIGO_MFT");
            entity.Property(e => e.ComisionTf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("COMISION_TF");
            entity.Property(e => e.EstadoTf)
                .HasMaxLength(25)
                .HasColumnName("ESTADO_TF");
            entity.Property(e => e.FaltaTf)
                .HasColumnType("datetime")
                .HasColumnName("FALTA_TF");
            entity.Property(e => e.FestadoTf)
                .HasColumnType("datetime")
                .HasColumnName("FESTADO_TF");
            entity.Property(e => e.GestionTf)
                .HasMaxLength(11)
                .HasColumnName("GESTION_TF");
            entity.Property(e => e.IdAdminOperTf).HasColumnName("ID_ADMIN_OPER_TF");
            entity.Property(e => e.IdAleatorio)
                .HasMaxLength(15)
                .HasColumnName("ID_ALEATORIO");
            entity.Property(e => e.IdColectivoTf).HasColumnName("ID_COLECTIVO_TF");
            entity.Property(e => e.ImporteacuentaTf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTEACUENTA_TF");
            entity.Property(e => e.ImportebaseTf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTEBASE_TF");
            entity.Property(e => e.ImportecuotaTf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTECUOTA_TF");
            entity.Property(e => e.ImportefinanciadoTf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTEFINANCIADO_TF");
            entity.Property(e => e.ImportetotalTf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTETOTAL_TF");
            entity.Property(e => e.NumerocuotasTf).HasColumnName("NUMEROCUOTAS_TF");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.TipoMft).HasColumnName("TIPO_MFT");
        });

        modelBuilder.Entity<ProvTiposPeticiones>(entity =>
        {
            entity.HasKey(e => e.IdTipoPeticion);

            entity.ToTable("prov_TiposPeticiones");

            entity.Property(e => e.IdTipoPeticion).HasColumnName("idTipoPeticion");
            entity.Property(e => e.Estado)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<ProvTitulares>(entity =>
        {
            entity.HasKey(e => new { e.Nif, e.IdCliente });

            entity.ToTable("prov_Titulares");

            entity.Property(e => e.Nif).HasMaxLength(15);
            entity.Property(e => e.Cp).HasMaxLength(5);
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.InfoAdicional).HasColumnType("ntext");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(50)
                .HasColumnName("nombre_completo");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Poblacion).HasMaxLength(100);
            entity.Property(e => e.Provincia).HasMaxLength(100);
            entity.Property(e => e.TelefonoFijo)
                .HasMaxLength(50)
                .HasColumnName("telefonoFijo");
            entity.Property(e => e.TelefonoMovil)
                .HasMaxLength(50)
                .HasColumnName("telefonoMovil");
        });

        modelBuilder.Entity<ProvUsuarios>(entity =>
        {
            entity.HasKey(e => new { e.Nif, e.IdCliente })
                .HasName("aaaaaprov_Usuarios_prueba_PK")
                .IsClustered(false);

            entity.ToTable("prov_usuarios");

            entity.Property(e => e.Nif).HasMaxLength(15);
            entity.Property(e => e.Cp).HasMaxLength(5);
            entity.Property(e => e.CuentaContable).HasMaxLength(50);
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.EstadoSincro)
                .HasMaxLength(50)
                .HasColumnName("Estado_sincro");
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaEstadoSincro)
                .HasColumnType("datetime")
                .HasColumnName("FechaEstado_sincro");
            entity.Property(e => e.FechaModif).HasColumnType("datetime");
            entity.Property(e => e.FechaNr)
                .HasColumnType("datetime")
                .HasColumnName("FechaNR");
            entity.Property(e => e.FechaOrdenDomiciliacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_orden_domiciliacion");
            entity.Property(e => e.Fumr)
                .HasMaxLength(25)
                .HasColumnName("FUMR");
            entity.Property(e => e.IdServidor).HasColumnName("id_servidor");
            entity.Property(e => e.IdUsuarioProlin)
                .ValueGeneratedOnAdd()
                .HasColumnName("idUsuarioProlin");
            entity.Property(e => e.InfoAdicional).HasColumnType("ntext");
            entity.Property(e => e.NiftitularBanco)
                .HasMaxLength(15)
                .HasColumnName("NIFTitularBanco");
            entity.Property(e => e.NivelRiesgo).HasMaxLength(4);
            entity.Property(e => e.NombreBanco).HasMaxLength(50);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(50)
                .HasColumnName("nombre_completo");
            entity.Property(e => e.NumCuenta).HasMaxLength(50);
            entity.Property(e => e.NumSocio).HasMaxLength(50);
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Poblacion).HasMaxLength(100);
            entity.Property(e => e.Provincia).HasMaxLength(100);
            entity.Property(e => e.RefOrdenDomiciliacion)
                .HasMaxLength(35)
                .HasColumnName("ref_orden_domiciliacion");
            entity.Property(e => e.TelefonoFijo)
                .HasMaxLength(50)
                .HasColumnName("telefonoFijo");
            entity.Property(e => e.TelefonoMovil)
                .HasMaxLength(50)
                .HasColumnName("telefonoMovil");
            entity.Property(e => e.TitularBanco).HasMaxLength(100);
        });

        modelBuilder.Entity<ProvVersionesApp>(entity =>
        {
            entity.HasKey(e => e.IdVersion)
                .HasName("aaaaaprov_VersionesApp_PK")
                .IsClustered(false);

            entity.ToTable("prov_VersionesApp");

            entity.Property(e => e.IdVersion).HasColumnName("idVersion");
            entity.Property(e => e.Descripcion)
                .HasColumnType("ntext")
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(25)
                .HasColumnName("estado");
            entity.Property(e => e.Fichero)
                .HasMaxLength(100)
                .HasColumnName("fichero");
            entity.Property(e => e.NombreApp)
                .HasMaxLength(50)
                .HasColumnName("nombreApp");
            entity.Property(e => e.Ruta)
                .HasMaxLength(255)
                .HasColumnName("ruta");
            entity.Property(e => e.Version)
                .HasMaxLength(10)
                .HasColumnName("version");
        });

        modelBuilder.Entity<Proyectos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIF");
            entity.Property(e => e.CodProyecto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codProyecto");
            entity.Property(e => e.DescCorta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescLarga).IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaImportacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoProyecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ush)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USH");
        });

        modelBuilder.Entity<QryAltaSocios>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryAltaSocios");

            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.Comentarios).HasMaxLength(4000);
            entity.Property(e => e.CosteDatos).HasColumnName("costeDatos");
            entity.Property(e => e.CosteTerminalPvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("costeTerminalPVP");
            entity.Property(e => e.Cp).HasMaxLength(5);
            entity.Property(e => e.Datos).HasColumnName("datos");
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.DniAdminLegal)
                .HasMaxLength(9)
                .HasColumnName("dni_admin_legal");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.IdfinanTf).HasColumnName("idfinan_TF");
            entity.Property(e => e.ImporteFianza).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InfoAdicional).HasColumnType("ntext");
            entity.Property(e => e.LimiteConsumo).HasMaxLength(50);
            entity.Property(e => e.Nif).HasMaxLength(15);
            entity.Property(e => e.NifTitular)
                .HasMaxLength(13)
                .HasColumnName("nifTitular");
            entity.Property(e => e.NiftitularBanco)
                .HasMaxLength(15)
                .HasColumnName("NIFTitularBanco");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NombreAdminLegal)
                .HasMaxLength(255)
                .HasColumnName("nombre_admin_legal");
            entity.Property(e => e.NombreBanco).HasMaxLength(50);
            entity.Property(e => e.NombreTitular)
                .HasMaxLength(50)
                .HasColumnName("nombreTitular");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .HasColumnName("nombreUsuario");
            entity.Property(e => e.NumCuenta).HasMaxLength(50);
            entity.Property(e => e.NumSocio).HasMaxLength(50);
            entity.Property(e => e.NumTelefono).HasMaxLength(50);
            entity.Property(e => e.NumVf)
                .HasMaxLength(10)
                .HasColumnName("numVF");
            entity.Property(e => e.Operador).HasMaxLength(50);
            entity.Property(e => e.OrigenLinea).HasMaxLength(50);
            entity.Property(e => e.OtrosServicios)
                .HasMaxLength(1000)
                .HasColumnName("otrosServicios");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Poblacion).HasMaxLength(100);
            entity.Property(e => e.PoblacionEmpresa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("poblacionEmpresa");
            entity.Property(e => e.Provincia).HasMaxLength(100);
            entity.Property(e => e.Restricciones)
                .HasMaxLength(1000)
                .HasColumnName("restricciones");
            entity.Property(e => e.SimDonante)
                .HasMaxLength(25)
                .HasColumnName("simDonante");
            entity.Property(e => e.TarifaDatos)
                .HasMaxLength(255)
                .HasColumnName("tarifaDatos");
            entity.Property(e => e.Terminal)
                .HasMaxLength(255)
                .HasColumnName("terminal");
            entity.Property(e => e.TerminalFinanciado).HasColumnName("terminalFinanciado");
            entity.Property(e => e.TitularBanco).HasMaxLength(100);
            entity.Property(e => e.Vodafonefijo).HasColumnName("vodafonefijo");
        });

        modelBuilder.Entity<QryCiclosxEmpresaAgrupado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryCiclosxEmpresa_Agrupado");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Fechafin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHAFIN");
            entity.Property(e => e.Fechainicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHAINICIO");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.NifCif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIF_CIF");
        });

        modelBuilder.Entity<QryConstruirCatalogo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryConstruirCatalogo");

            entity.Property(e => e.CategoriaTerm)
                .HasMaxLength(1)
                .HasColumnName("CATEGORIA_TERM");
            entity.Property(e => e.CodTarifa)
                .HasMaxLength(25)
                .HasColumnName("COD_TARIFA");
            entity.Property(e => e.CodtarifaOperador)
                .HasMaxLength(50)
                .HasColumnName("codtarifa_operador");
            entity.Property(e => e.CuentaVf)
                .HasMaxLength(15)
                .HasColumnName("cuenta_vf");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstadoCat)
                .HasMaxLength(25)
                .HasColumnName("ESTADO_CAT");
            entity.Property(e => e.GamaTerm)
                .HasMaxLength(25)
                .HasColumnName("GAMA_TERM");
            entity.Property(e => e.IdCat).HasColumnName("ID_CAT");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.IdTerm).HasColumnName("ID_TERM");
            entity.Property(e => e.Informecatalogo)
                .HasMaxLength(50)
                .HasColumnName("INFORMECATALOGO");
            entity.Property(e => e.MargenTerminal).HasMaxLength(15);
            entity.Property(e => e.NombreTerm)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE_TERM");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.PorcentajeDtoCatalogoOp).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.PrecioCoste)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precioCoste");
            entity.Property(e => e.PrecioNeto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precioNeto");
            entity.Property(e => e.PrecioTerm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRECIO_TERM");
            entity.Property(e => e.ReferenciaTerm)
                .HasMaxLength(15)
                .HasColumnName("REFERENCIA_TERM");
            entity.Property(e => e.SubvencionAlta)
                .HasMaxLength(10)
                .HasColumnName("subvencionAlta");
            entity.Property(e => e.SubvencionUpsell)
                .HasMaxLength(10)
                .HasColumnName("subvencionUpsell");
            entity.Property(e => e.VolumenDatos).HasMaxLength(50);
        });

        modelBuilder.Entity<QryConsumoMinimo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryConsumoMinimo");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.CvDescontado)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("CV_DESCONTADO");
            entity.Property(e => e.CvExigido)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("CV_EXIGIDO");
            entity.Property(e => e.CvPenalizacion)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("CV_PENALIZACION");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.Telef2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
            entity.Property(e => e.Totalvoz)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("TOTALVOZ");
        });

        modelBuilder.Entity<QryConsumoMre>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryConsumoMRE");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.DescripCuota)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DESCRIP_CUOTA");
            entity.Property(e => e.Fechafin)
                .HasMaxLength(50)
                .HasColumnName("FECHAFIN");
            entity.Property(e => e.Fechainicio)
                .HasMaxLength(50)
                .HasColumnName("FECHAINICIO");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.PenalVf)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("PENAL_VF");
            entity.Property(e => e.SumaDeDescuento)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("SumaDeDESCUENTO");
            entity.Property(e => e.SumaDeImporte)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("SumaDeIMPORTE");
            entity.Property(e => e.Telef2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
        });

        modelBuilder.Entity<QryConsumoVozxLineayCiclo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryConsumoVozxLineayCiclo");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.SumaDeImporteNeto)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("SumaDeIMPORTE_NETO");
            entity.Property(e => e.Telef2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
            entity.Property(e => e.Tipocons)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TIPOCONS");
        });

        modelBuilder.Entity<QryDireccionFacturacionClientes>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryDireccionFacturacionClientes");

            entity.Property(e => e.CodPostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Poblacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QryDireccionFacturacionUsuarios>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryDireccionFacturacionUsuarios");

            entity.Property(e => e.CodPostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Poblacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QryEmpresaAmpliada>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryEmpresaAmpliada");

            entity.Property(e => e.Ciclo).HasColumnName("CICLO");
            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.CuentaVf)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CUENTA_VF");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaUltimaRenovacionContratoVf)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ULTIMA_RENOVACION_CONTRATO_VF");
            entity.Property(e => e.FinanciaTerminales).HasColumnName("FINANCIA_TERMINALES");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdcVinculada).HasColumnName("IDC_VINCULADA");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Nombrevd)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBREVD");
            entity.Property(e => e.Poblacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RangoExt).HasMaxLength(15);
            entity.Property(e => e.RevendedorDe).HasColumnName("REVENDEDOR_DE");
            entity.Property(e => e.Sfid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SFID");
        });

        modelBuilder.Entity<QryEnviosLineas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryEnviosLineas");

            entity.Property(e => e.Ciclo).HasColumnName("CICLO");
            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.CodigosEstado)
                .HasMaxLength(255)
                .HasColumnName("codigosEstado");
            entity.Property(e => e.CodtarifaOperador)
                .HasMaxLength(25)
                .HasColumnName("codtarifa_operador");
            entity.Property(e => e.Comentarios).HasMaxLength(4000);
            entity.Property(e => e.CosteDatos).HasColumnName("costeDatos");
            entity.Property(e => e.CosteTerminal)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("costeTerminal");
            entity.Property(e => e.CosteTerminalPvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("costeTerminalPVP");
            entity.Property(e => e.CpTitular).HasMaxLength(5);
            entity.Property(e => e.CuentaVf)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CUENTA_VF");
            entity.Property(e => e.CuentaVf2)
                .HasMaxLength(15)
                .HasColumnName("cuenta_vf2");
            entity.Property(e => e.Datos).HasColumnName("datos");
            entity.Property(e => e.DireccionTitular).HasMaxLength(100);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.EstadoSincro)
                .HasMaxLength(50)
                .HasColumnName("Estado_sincro");
            entity.Property(e => e.EstadoUsuario).HasMaxLength(50);
            entity.Property(e => e.Extension)
                .HasMaxLength(6)
                .HasColumnName("extension");
            entity.Property(e => e.FechaActivacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaActivacion");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaEntregaTerminal).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fechaEstado");
            entity.Property(e => e.FechaEstadoSincro)
                .HasColumnType("datetime")
                .HasColumnName("FechaEstado_sincro");
            entity.Property(e => e.FechaPublicacionTerminal).HasColumnType("datetime");
            entity.Property(e => e.FechaVc)
                .HasColumnType("datetime")
                .HasColumnName("fechaVC");
            entity.Property(e => e.FinanciaTerminales).HasColumnName("FINANCIA_TERMINALES");
            entity.Property(e => e.Franquicia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FranquiciaMax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdAdmin).HasColumnName("idAdmin");
            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.IdServidor).HasColumnName("id_servidor");
            entity.Property(e => e.IdcVinculada).HasColumnName("IDC_VINCULADA");
            entity.Property(e => e.IdfinanTf).HasColumnName("idfinan_TF");
            entity.Property(e => e.Imei)
                .HasMaxLength(20)
                .HasColumnName("imei");
            entity.Property(e => e.ImeiTermActual).HasMaxLength(25);
            entity.Property(e => e.ImporteFianza).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImportePendiente).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InfoAdicional).HasColumnType("ntext");
            entity.Property(e => e.LimiteConsumo).HasMaxLength(50);
            entity.Property(e => e.MotivoIncidencia)
                .HasMaxLength(50)
                .HasColumnName("MOTIVO_INCIDENCIA");
            entity.Property(e => e.NifTitular)
                .HasMaxLength(13)
                .HasColumnName("nifTitular");
            entity.Property(e => e.NifTitular1)
                .HasMaxLength(15)
                .HasColumnName("Nif_Titular");
            entity.Property(e => e.NifUsuario)
                .HasMaxLength(13)
                .HasColumnName("nifUsuario");
            entity.Property(e => e.NifUsuario1)
                .HasMaxLength(15)
                .HasColumnName("Nif_Usuario");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NombreTitular).HasMaxLength(50);
            entity.Property(e => e.NombreUsuario).HasMaxLength(50);
            entity.Property(e => e.Nombrevd)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBREVD");
            entity.Property(e => e.NumTelefono).HasMaxLength(50);
            entity.Property(e => e.NumVf)
                .HasMaxLength(10)
                .HasColumnName("numVF");
            entity.Property(e => e.Operador).HasMaxLength(50);
            entity.Property(e => e.OrdenDeLista).HasColumnName("ordenDeLista");
            entity.Property(e => e.Origen).HasMaxLength(50);
            entity.Property(e => e.Otros).HasColumnName("otros");
            entity.Property(e => e.OtrosServicios)
                .HasMaxLength(255)
                .HasColumnName("otrosServicios");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Pin)
                .HasMaxLength(4)
                .HasColumnName("pin");
            entity.Property(e => e.Poblacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PoblacionTitular).HasMaxLength(100);
            entity.Property(e => e.PrecioCoste)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precioCoste");
            entity.Property(e => e.ProvinciaTitular).HasMaxLength(100);
            entity.Property(e => e.Puk)
                .HasMaxLength(8)
                .HasColumnName("puk");
            entity.Property(e => e.RangoExt).HasMaxLength(15);
            entity.Property(e => e.Restricciones)
                .HasMaxLength(150)
                .HasColumnName("restricciones");
            entity.Property(e => e.RevendedorDe).HasColumnName("REVENDEDOR_DE");
            entity.Property(e => e.Sfid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SFID");
            entity.Property(e => e.SimActual)
                .HasMaxLength(25)
                .HasColumnName("simActual");
            entity.Property(e => e.SimDonante)
                .HasMaxLength(25)
                .HasColumnName("simDonante");
            entity.Property(e => e.TarifaDatos)
                .HasMaxLength(255)
                .HasColumnName("tarifaDatos");
            entity.Property(e => e.Terminal)
                .HasMaxLength(255)
                .HasColumnName("terminal");
            entity.Property(e => e.TerminalActual).HasMaxLength(255);
            entity.Property(e => e.TerminalFinanciado).HasColumnName("terminalFinanciado");
            entity.Property(e => e.Ultimaextension).HasMaxLength(6);
            entity.Property(e => e.Vodafonefijo).HasColumnName("vodafonefijo");
        });

        modelBuilder.Entity<QryInfGestion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryINF_GESTION");

            entity.Property(e => e.CodPostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Colectivo).HasMaxLength(50);
            entity.Property(e => e.DescTarifadatos)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Linea).HasMaxLength(25);
            entity.Property(e => e.Nif)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.NumCuenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Operador)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Origen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Poblacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SFax)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("sFax");
            entity.Property(e => e.TarifaDatos)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Vfijo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VFIJO");
        });

        modelBuilder.Entity<QryInfProvision>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryINF_PROVISION");

            entity.Property(e => e.Colectivo).HasMaxLength(50);
            entity.Property(e => e.Cp).HasMaxLength(5);
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fechaEstado");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Linea).HasMaxLength(50);
            entity.Property(e => e.NifUsuario)
                .HasMaxLength(13)
                .HasColumnName("nifUsuario");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .HasColumnName("nombreUsuario");
            entity.Property(e => e.NumCuenta).HasMaxLength(50);
            entity.Property(e => e.Operador).HasMaxLength(50);
            entity.Property(e => e.Origen).HasMaxLength(50);
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Poblacion).HasMaxLength(100);
            entity.Property(e => e.Provincia).HasMaxLength(100);
            entity.Property(e => e.TarifaDatos)
                .HasMaxLength(255)
                .HasColumnName("tarifaDatos");
            entity.Property(e => e.Terminal)
                .HasMaxLength(255)
                .HasColumnName("terminal");
            entity.Property(e => e.TerminalFinanciado).HasColumnName("terminalFinanciado");
        });

        modelBuilder.Entity<QryPagosFacturaColectivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryPagosFacturaColectivo");

            entity.Property(e => e.CodPago)
                .HasMaxLength(25)
                .HasColumnName("codPago");
            entity.Property(e => e.ConceptoPago)
                .HasMaxLength(100)
                .HasColumnName("conceptoPago");
            entity.Property(e => e.IdFactura).HasColumnName("idFactura");
            entity.Property(e => e.IdFacturaOrigenPago).HasColumnName("idFacturaOrigenPago");
            entity.Property(e => e.IdLinea).HasColumnName("idLinea");
            entity.Property(e => e.IdPago).HasColumnName("idPago");
            entity.Property(e => e.ImportePago)
                .HasColumnType("decimal(20, 4)")
                .HasColumnName("importePago");
            entity.Property(e => e.NumFactura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumLinea)
                .HasMaxLength(15)
                .HasColumnName("numLinea");
            entity.Property(e => e.NumPago).HasColumnName("numPago");
            entity.Property(e => e.PlazosPago).HasColumnName("plazosPago");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(15)
                .HasColumnName("tipoPago");
        });

        modelBuilder.Entity<QryPrlaccLineas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryPRLACC_lineas");

            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.CodigosEstado)
                .HasMaxLength(255)
                .HasColumnName("codigosEstado");
            entity.Property(e => e.Comentarios).HasMaxLength(4000);
            entity.Property(e => e.CosteDatos).HasColumnName("costeDatos");
            entity.Property(e => e.CosteTerminal)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("costeTerminal");
            entity.Property(e => e.CosteTerminalPvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("costeTerminalPVP");
            entity.Property(e => e.Cp).HasMaxLength(5);
            entity.Property(e => e.Datos).HasColumnName("datos");
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.EstadoSincro)
                .HasMaxLength(50)
                .HasColumnName("Estado_sincro");
            entity.Property(e => e.EstadoUsuario).HasMaxLength(50);
            entity.Property(e => e.Extension)
                .HasMaxLength(6)
                .HasColumnName("extension");
            entity.Property(e => e.FechaActivacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaActivacion");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaEntregaTerminal).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fechaEstado");
            entity.Property(e => e.FechaEstadoSincro)
                .HasColumnType("datetime")
                .HasColumnName("FechaEstado_sincro");
            entity.Property(e => e.FechaPublicacionTerminal).HasColumnType("datetime");
            entity.Property(e => e.FechaVc)
                .HasColumnType("datetime")
                .HasColumnName("fechaVC");
            entity.Property(e => e.Franquicia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FranquiciaMax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdAdmin).HasColumnName("idAdmin");
            entity.Property(e => e.IdCatpc).HasColumnName("ID_CATPC");
            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.IdCliente1).HasColumnName("id_cliente");
            entity.Property(e => e.IdNumpc).HasColumnName("ID_NUMPC");
            entity.Property(e => e.IdServidor).HasColumnName("id_servidor");
            entity.Property(e => e.IdcVinculada).HasColumnName("IDC_VINCULADA");
            entity.Property(e => e.IdfinanTf).HasColumnName("idfinan_TF");
            entity.Property(e => e.Imei)
                .HasMaxLength(20)
                .HasColumnName("imei");
            entity.Property(e => e.ImeiTermActual).HasMaxLength(25);
            entity.Property(e => e.ImporteFianza).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImportePendiente).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InfoAdicional).HasColumnType("ntext");
            entity.Property(e => e.LimiteConsumo).HasMaxLength(50);
            entity.Property(e => e.NifTitular)
                .HasMaxLength(13)
                .HasColumnName("nifTitular");
            entity.Property(e => e.NifTitular1)
                .HasMaxLength(15)
                .HasColumnName("Nif_Titular");
            entity.Property(e => e.NifUsuario)
                .HasMaxLength(13)
                .HasColumnName("nifUsuario");
            entity.Property(e => e.NifUsuario1)
                .HasMaxLength(15)
                .HasColumnName("Nif_Usuario");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NombreComercialPerfil).HasMaxLength(250);
            entity.Property(e => e.NombreTitular)
                .HasMaxLength(50)
                .HasColumnName("nombreTitular");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .HasColumnName("nombreUsuario");
            entity.Property(e => e.NumTelefono).HasMaxLength(50);
            entity.Property(e => e.NumVf)
                .HasMaxLength(10)
                .HasColumnName("numVF");
            entity.Property(e => e.Operador).HasMaxLength(50);
            entity.Property(e => e.OrdenDeLista).HasColumnName("ordenDeLista");
            entity.Property(e => e.Origen).HasMaxLength(50);
            entity.Property(e => e.Otros).HasColumnName("otros");
            entity.Property(e => e.OtrosServicios)
                .HasMaxLength(1000)
                .HasColumnName("otrosServicios");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Pin)
                .HasMaxLength(4)
                .HasColumnName("pin");
            entity.Property(e => e.Poblacion).HasMaxLength(100);
            entity.Property(e => e.Provincia).HasMaxLength(100);
            entity.Property(e => e.Puk)
                .HasMaxLength(8)
                .HasColumnName("puk");
            entity.Property(e => e.Restricciones)
                .HasMaxLength(1000)
                .HasColumnName("restricciones");
            entity.Property(e => e.SimActual)
                .HasMaxLength(25)
                .HasColumnName("simActual");
            entity.Property(e => e.SimDonante)
                .HasMaxLength(25)
                .HasColumnName("simDonante");
            entity.Property(e => e.TarifaDatos)
                .HasMaxLength(255)
                .HasColumnName("tarifaDatos");
            entity.Property(e => e.Terminal)
                .HasMaxLength(255)
                .HasColumnName("terminal");
            entity.Property(e => e.TerminalActual).HasMaxLength(255);
            entity.Property(e => e.TerminalFinanciado).HasColumnName("terminalFinanciado");
            entity.Property(e => e.Vodafonefijo).HasColumnName("vodafonefijo");
        });

        modelBuilder.Entity<QryPrlaccLineasExt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryPRLACC_lineasExt");

            entity.Property(e => e.CodigosEstado)
                .HasMaxLength(255)
                .HasColumnName("codigosEstado");
            entity.Property(e => e.Comentarios).HasMaxLength(4000);
            entity.Property(e => e.CosteDatos).HasColumnName("costeDatos");
            entity.Property(e => e.CosteTerminal)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("costeTerminal");
            entity.Property(e => e.CosteTerminalPvp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("costeTerminalPVP");
            entity.Property(e => e.CpTitular).HasMaxLength(5);
            entity.Property(e => e.Datos).HasColumnName("datos");
            entity.Property(e => e.DireccionTitular).HasMaxLength(100);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.EstadoSincro)
                .HasMaxLength(50)
                .HasColumnName("Estado_sincro");
            entity.Property(e => e.EstadoUsuario).HasMaxLength(50);
            entity.Property(e => e.Extension)
                .HasMaxLength(6)
                .HasColumnName("extension");
            entity.Property(e => e.FechaActivacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaActivacion");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaEntregaTerminal).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fechaEstado");
            entity.Property(e => e.FechaEstadoSincro)
                .HasColumnType("datetime")
                .HasColumnName("FechaEstado_sincro");
            entity.Property(e => e.FechaPublicacionTerminal).HasColumnType("datetime");
            entity.Property(e => e.FechaVc)
                .HasColumnType("datetime")
                .HasColumnName("fechaVC");
            entity.Property(e => e.Franquicia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FranquiciaMax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdAdmin).HasColumnName("idAdmin");
            entity.Property(e => e.IdCatpc).HasColumnName("ID_CATPC");
            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.IdNumpc).HasColumnName("ID_NUMPC");
            entity.Property(e => e.IdServidor).HasColumnName("id_servidor");
            entity.Property(e => e.IdfinanTf).HasColumnName("idfinan_TF");
            entity.Property(e => e.Imei)
                .HasMaxLength(20)
                .HasColumnName("imei");
            entity.Property(e => e.ImeiTermActual).HasMaxLength(25);
            entity.Property(e => e.ImporteFianza).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImportePendiente).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InfoAdicional).HasColumnType("ntext");
            entity.Property(e => e.LimiteConsumo).HasMaxLength(50);
            entity.Property(e => e.MotivoIncidencia)
                .HasMaxLength(50)
                .HasColumnName("MOTIVO_INCIDENCIA");
            entity.Property(e => e.NifTitular)
                .HasMaxLength(13)
                .HasColumnName("nifTitular");
            entity.Property(e => e.NifTitular1)
                .HasMaxLength(15)
                .HasColumnName("Nif_Titular");
            entity.Property(e => e.NifUsuario)
                .HasMaxLength(13)
                .HasColumnName("nifUsuario");
            entity.Property(e => e.NifUsuario1)
                .HasMaxLength(15)
                .HasColumnName("Nif_Usuario");
            entity.Property(e => e.NombreTitular).HasMaxLength(50);
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .HasColumnName("nombreUsuario");
            entity.Property(e => e.NumTelefono).HasMaxLength(50);
            entity.Property(e => e.NumVf)
                .HasMaxLength(10)
                .HasColumnName("numVF");
            entity.Property(e => e.Operador).HasMaxLength(50);
            entity.Property(e => e.OrdenDeLista).HasColumnName("ordenDeLista");
            entity.Property(e => e.Origen).HasMaxLength(50);
            entity.Property(e => e.Otros).HasColumnName("otros");
            entity.Property(e => e.OtrosServicios)
                .HasMaxLength(1000)
                .HasColumnName("otrosServicios");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Pin)
                .HasMaxLength(4)
                .HasColumnName("pin");
            entity.Property(e => e.PoblacionTitular).HasMaxLength(100);
            entity.Property(e => e.ProvinciaTitular).HasMaxLength(100);
            entity.Property(e => e.Puk)
                .HasMaxLength(8)
                .HasColumnName("puk");
            entity.Property(e => e.Restricciones)
                .HasMaxLength(1000)
                .HasColumnName("restricciones");
            entity.Property(e => e.SimActual)
                .HasMaxLength(25)
                .HasColumnName("simActual");
            entity.Property(e => e.SimDonante)
                .HasMaxLength(25)
                .HasColumnName("simDonante");
            entity.Property(e => e.TarifaDatos)
                .HasMaxLength(255)
                .HasColumnName("tarifaDatos");
            entity.Property(e => e.Terminal)
                .HasMaxLength(255)
                .HasColumnName("terminal");
            entity.Property(e => e.TerminalActual).HasMaxLength(255);
            entity.Property(e => e.TerminalFinanciado).HasColumnName("terminalFinanciado");
            entity.Property(e => e.Vodafonefijo).HasColumnName("vodafonefijo");
        });

        modelBuilder.Entity<QryReparacionTerminales>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryReparacionTerminales");

            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.EstadoSolicitud)
                .HasMaxLength(50)
                .HasColumnName("estado_solicitud");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fecha_estado");
            entity.Property(e => e.HistoricoComentarios)
                .HasMaxLength(4000)
                .HasColumnName("historicoComentarios");
            entity.Property(e => e.IdColectivo).HasColumnName("id_colectivo");
            entity.Property(e => e.IdLinea).HasColumnName("id_linea");
            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.LugarRecogida).HasMaxLength(50);
            entity.Property(e => e.MargenTerminal).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.NumTelefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrdenOperador)
                .HasMaxLength(50)
                .HasColumnName("orden_operador");
            entity.Property(e => e.TarifaDatos)
                .HasMaxLength(50)
                .HasColumnName("tarifaDatos");
            entity.Property(e => e.TipoSolicitud)
                .HasMaxLength(50)
                .HasColumnName("tipo_solicitud");
            entity.Property(e => e.TnCosteEuros)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("tn_coste_euros");
            entity.Property(e => e.TnCosteEvfTotal)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("tn_costeEVF_total");
            entity.Property(e => e.TnCostePuntos)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("tn_coste_puntos");
            entity.Property(e => e.TnCosteSubvencionPuntos)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("tn_coste_subvencion_puntos");
            entity.Property(e => e.TnImei)
                .HasMaxLength(20)
                .HasColumnName("tn_imei");
            entity.Property(e => e.TnMarcaModelo)
                .HasMaxLength(101)
                .HasColumnName("tn_marca_MODELO");
            entity.Property(e => e.TvBateria)
                .HasMaxLength(50)
                .HasColumnName("tv_bateria");
            entity.Property(e => e.TvCargador)
                .HasMaxLength(50)
                .HasColumnName("tv_cargador");
            entity.Property(e => e.TvDesperfectos)
                .HasMaxLength(255)
                .HasColumnName("tv_desperfectos");
            entity.Property(e => e.TvImei)
                .HasMaxLength(20)
                .HasColumnName("tv_imei");
            entity.Property(e => e.TvMarcaModelo)
                .HasMaxLength(101)
                .HasColumnName("tv_marca_MODELO");
            entity.Property(e => e.TvTerminal)
                .HasMaxLength(50)
                .HasColumnName("tv_Terminal");
        });

        modelBuilder.Entity<QryReparacionTerminalesExtend>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryReparacionTerminalesExtend");

            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.CodPostalRecogida)
                .HasMaxLength(5)
                .HasColumnName("codPostalRecogida");
            entity.Property(e => e.DireccionRecogida)
                .HasMaxLength(1000)
                .HasColumnName("direccionRecogida");
            entity.Property(e => e.EstadoSolicitud)
                .HasMaxLength(50)
                .HasColumnName("estado_solicitud");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fecha_estado");
            entity.Property(e => e.HistoricoComentarios)
                .HasMaxLength(4000)
                .HasColumnName("historicoComentarios");
            entity.Property(e => e.IdColectivo).HasColumnName("id_colectivo");
            entity.Property(e => e.IdLinea).HasColumnName("id_linea");
            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.LugarRecogida).HasMaxLength(50);
            entity.Property(e => e.MargenTerminal).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.NombreContactoComercial)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombreContactoComercial");
            entity.Property(e => e.NumTelefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrdenOperador)
                .HasMaxLength(50)
                .HasColumnName("orden_operador");
            entity.Property(e => e.PoblacionRecogida)
                .HasMaxLength(50)
                .HasColumnName("poblacionRecogida");
            entity.Property(e => e.ProvinciaRecogida)
                .HasMaxLength(50)
                .HasColumnName("provinciaRecogida");
            entity.Property(e => e.Sfid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SFID");
            entity.Property(e => e.TarifaDatos)
                .HasMaxLength(50)
                .HasColumnName("tarifaDatos");
            entity.Property(e => e.TipoSolicitud)
                .HasMaxLength(50)
                .HasColumnName("tipo_solicitud");
            entity.Property(e => e.TnCosteEuros)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("tn_coste_euros");
            entity.Property(e => e.TnCosteEvfTotal)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("tn_costeEVF_total");
            entity.Property(e => e.TnCostePuntos)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("tn_coste_puntos");
            entity.Property(e => e.TnCosteSubvencionPuntos)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("tn_coste_subvencion_puntos");
            entity.Property(e => e.TnImei)
                .HasMaxLength(20)
                .HasColumnName("tn_imei");
            entity.Property(e => e.TnMarcaModelo)
                .HasMaxLength(101)
                .HasColumnName("tn_marca_MODELO");
            entity.Property(e => e.TvBateria)
                .HasMaxLength(50)
                .HasColumnName("tv_bateria");
            entity.Property(e => e.TvCargador)
                .HasMaxLength(50)
                .HasColumnName("tv_cargador");
            entity.Property(e => e.TvDesperfectos)
                .HasMaxLength(255)
                .HasColumnName("tv_desperfectos");
            entity.Property(e => e.TvImei)
                .HasMaxLength(20)
                .HasColumnName("tv_imei");
            entity.Property(e => e.TvMarcaModelo)
                .HasMaxLength(101)
                .HasColumnName("tv_marca_MODELO");
            entity.Property(e => e.TvTerminal)
                .HasMaxLength(50)
                .HasColumnName("tv_Terminal");
        });

        modelBuilder.Entity<QryResumenFacturacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryResumenFacturacion");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.DesConsumo).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.DesCuota).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.ImpConsumo).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.ImpCuota).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.Telef2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<QryResumenFacturacionLineaConsumos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryResumenFacturacionLinea_Consumos");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Descuento).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.SumaDeImporte)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("SumaDeIMPORTE");
            entity.Property(e => e.SumaDeImporteNeto)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("SumaDeIMPORTE_NETO");
            entity.Property(e => e.Telef2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
        });

        modelBuilder.Entity<QryResumenFacturacionLineaCuotas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryResumenFacturacionLinea_Cuotas");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.SumaDeDescuento)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("SumaDeDESCUENTO");
            entity.Property(e => e.SumaDeImporte)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("SumaDeIMPORTE");
            entity.Property(e => e.Telef2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<QryResumenFacturacionLineaDatos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryResumenFacturacionLinea_Datos");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Descuento).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.SumaDeImporte)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("SumaDeIMPORTE");
            entity.Property(e => e.SumaDeImporteNeto)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("SumaDeIMPORTE_NETO");
            entity.Property(e => e.Telef2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
        });

        modelBuilder.Entity<QryResumenLineasxCiclo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryResumenLineasxCiclo");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.Telef2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
        });

        modelBuilder.Entity<QryServiciosDatos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryServicios_Datos");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdServicio).ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QryServiciosFax>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryServicios_Fax");

            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SFax)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("sFax");
        });

        modelBuilder.Entity<QryServiciosVodafoneFijo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryServicios_Vodafone_Fijo");

            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vfijo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VFIJO");
        });

        modelBuilder.Entity<QryTarifasDatosUnicasxColectivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryTarifasDatosUnicasxColectivo");

            entity.Property(e => e.CodTarifa)
                .HasMaxLength(25)
                .HasColumnName("codTarifa");
            entity.Property(e => e.CodtarifaOperador)
                .HasMaxLength(25)
                .HasColumnName("codtarifa_operador");
            entity.Property(e => e.CuentaVf)
                .HasMaxLength(15)
                .HasColumnName("cuenta_vf");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.PrecioCoste)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precioCoste");
        });

        modelBuilder.Entity<QryTerminalesnoPublicados>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryTerminalesnoPublicados");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigosEstado)
                .HasMaxLength(255)
                .HasColumnName("codigosEstado");
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.Expr2).HasMaxLength(50);
            entity.Property(e => e.Expr3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.Imei)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ImporteCompra).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumTelefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Operador)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Origen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Terminal)
                .HasMaxLength(255)
                .HasColumnName("terminal");
        });

        modelBuilder.Entity<QryTmpResumenFacturacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryTMP_ResumenFacturacion");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.DesConsumo).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.DesCuota).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.ImpConsumo).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.ImpCuota).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.Telef2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<QryTmpResumenFacturacionCompleta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryTMP_ResumenFacturacionCompleta");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.DesConsumo).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.DesCuota).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExtNumTelefono)
                .HasMaxLength(9)
                .HasColumnName("extNumTelefono");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.Fechafin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHAFIN");
            entity.Property(e => e.Fechainicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHAINICIO");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.IdUsuarioLin).HasColumnName("IdUsuarioLIN");
            entity.Property(e => e.ImpConsumo).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.ImpCuota).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.NifCif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIF_CIF");
            entity.Property(e => e.Telef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telef");
            entity.Property(e => e.Telef3)
                .HasMaxLength(60)
                .HasColumnName("TELEF3");
            entity.Property(e => e.TipoLinea)
                .HasMaxLength(10)
                .HasColumnName("tipoLinea");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<QryTmpResumenFacturacionLineaConsumos>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryTMP_ResumenFacturacionLinea_Consumos");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Descuento).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.SumaDeImporte)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("SumaDeIMPORTE");
            entity.Property(e => e.SumaDeImporteNeto)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("SumaDeIMPORTE_NETO");
            entity.Property(e => e.Telef2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
        });

        modelBuilder.Entity<QryTmpResumenFacturacionLineaCuotas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryTMP_ResumenFacturacionLinea_Cuotas");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.SumaDeDescuento)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("SumaDeDESCUENTO");
            entity.Property(e => e.SumaDeImporte)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("SumaDeIMPORTE");
            entity.Property(e => e.Telef2)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<QryTmpResumenLineasxCiclo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryTMP_ResumenLineasxCiclo");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.Telef2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF2");
        });

        modelBuilder.Entity<QryUltimaExtensionxColectivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryUltimaExtensionxColectivo");

            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
        });

        modelBuilder.Entity<RelacionAcuerdos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ResponsablesEmpleados>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RESPONSABLES_EMPLEADOS");

            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .HasColumnName("AREA");
            entity.Property(e => e.Bu)
                .HasMaxLength(255)
                .HasColumnName("BU");
            entity.Property(e => e.DescrArea)
                .HasMaxLength(255)
                .HasColumnName("DESCR_AREA");
            entity.Property(e => e.DescrPosicion)
                .HasMaxLength(255)
                .HasColumnName("DESCR_POSICION");
            entity.Property(e => e.DescrPosicionReporte)
                .HasMaxLength(255)
                .HasColumnName("DESCR_POSICION_REPORTE");
            entity.Property(e => e.DescrPuesto)
                .HasMaxLength(255)
                .HasColumnName("DESCR_PUESTO");
            entity.Property(e => e.DescrUo)
                .HasMaxLength(255)
                .HasColumnName("DESCR_UO");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("F_NACIMIENTO");
            entity.Property(e => e.FfinContrato)
                .HasMaxLength(255)
                .HasColumnName("FFIN_CONTRATO");
            entity.Property(e => e.IdEmpleado)
                .HasMaxLength(255)
                .HasColumnName("ID_EMPLEADO");
            entity.Property(e => e.Manager)
                .HasMaxLength(255)
                .HasColumnName("MANAGER");
            entity.Property(e => e.Nif)
                .HasMaxLength(255)
                .HasColumnName("NIF");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NombreEmpleado)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE_EMPLEADO");
            entity.Property(e => e.NombreResponsable)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE_RESPONSABLE");
            entity.Property(e => e.OficinaTg).HasColumnName("OFICINA_TG");
            entity.Property(e => e.OpridRed)
                .HasMaxLength(255)
                .HasColumnName("OPRID_RED");
            entity.Property(e => e.Posicion)
                .HasMaxLength(255)
                .HasColumnName("POSICION");
            entity.Property(e => e.PosicionReporte)
                .HasMaxLength(255)
                .HasColumnName("POSICION_REPORTE");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(255)
                .HasColumnName("PRIMER_APELLIDO");
            entity.Property(e => e.Puesto).HasColumnName("PUESTO");
            entity.Property(e => e.Responsable)
                .HasMaxLength(255)
                .HasColumnName("RESPONSABLE");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(255)
                .HasColumnName("SEGUNDO_APELLIDO");
            entity.Property(e => e.Sexo)
                .HasMaxLength(255)
                .HasColumnName("SEXO");
            entity.Property(e => e.Uo).HasColumnName("UO");
        });

        modelBuilder.Entity<ResumenVozCuotasyConsumo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Resumen Voz(CuotasyConsumo)");

            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.CodigoPostal).HasMaxLength(50);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Descuento).HasColumnName("descuento");
            entity.Property(e => e.DomicilioTa)
                .HasMaxLength(50)
                .HasColumnName("DomicilioTA");
            entity.Property(e => e.DomicilioTb)
                .HasMaxLength(50)
                .HasColumnName("DomicilioTB");
            entity.Property(e => e.FechaAlta).HasMaxLength(50);
            entity.Property(e => e.FechaBaja).HasMaxLength(50);
            entity.Property(e => e.FechaFactura).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaFin).HasMaxLength(50);
            entity.Property(e => e.FechaInicio).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NombreProv).HasMaxLength(50);
            entity.Property(e => e.PoblacionTa)
                .HasMaxLength(50)
                .HasColumnName("PoblacionTA");
            entity.Property(e => e.PoblacionTb)
                .HasMaxLength(50)
                .HasColumnName("PoblacionTB");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<ScctPaises>(entity =>
        {
            entity.HasKey(e => e.CodPais);

            entity.ToTable("SCCT_Paises");

            entity.Property(e => e.CodPais)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codPais");
            entity.Property(e => e.DesPais)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("desPais");
            entity.Property(e => e.IdConcepto).HasColumnName("idConcepto");
            entity.Property(e => e.IdOperadora).HasColumnName("idOperadora");
        });

        modelBuilder.Entity<ScctZonas>(entity =>
        {
            entity.HasKey(e => new { e.IdOperador, e.CodZona });

            entity.ToTable("SCCT_Zonas");

            entity.Property(e => e.IdOperador).HasColumnName("idOperador");
            entity.Property(e => e.CodZona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codZona");
            entity.Property(e => e.CodTipoTrafico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codTipoTrafico");
            entity.Property(e => e.DesOperador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desOperador");
            entity.Property(e => e.DesTipoTrafico)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("desTipoTrafico");
            entity.Property(e => e.DesZona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desZona");
            entity.Property(e => e.TipoZona)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScttPaisesZonas>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SCTT_PaisesZonas");

            entity.Property(e => e.CodPais)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codPais");
            entity.Property(e => e.CodZona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codZona");
            entity.Property(e => e.IdOperador).HasColumnName("idOperador");
            entity.Property(e => e.IdPaisZona)
                .ValueGeneratedOnAdd()
                .HasColumnName("idPaisZona");

            entity.HasOne(d => d.ScctZonas).WithMany()
                .HasForeignKey(d => new { d.IdOperador, d.CodZona })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SCTT_PaisesZonas_SCCT_Zonas");
        });

        modelBuilder.Entity<SimulacionesTarifacion>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Fecha)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoraInicio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFactura");
            entity.Property(e => e.Parametros).IsUnicode(false);
            entity.Property(e => e.Parametros2).IsUnicode(false);
            entity.Property(e => e.Precio1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Precio2)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SistemaAuxTablasTh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SISTEMA_Aux_TablasTH");

            entity.Property(e => e.Accion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accion");
            entity.Property(e => e.EsDetalle).HasColumnName("esDetalle");
            entity.Property(e => e.Operador).HasColumnName("operador");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.StrSql)
                .HasMaxLength(7500)
                .IsUnicode(false)
                .HasColumnName("strSql");
            entity.Property(e => e.TablaTh)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tablaTH");
            entity.Property(e => e.TipoCarga).HasColumnName("tipoCarga");
        });

        modelBuilder.Entity<SistemaLogEjecucion>(entity =>
        {
            entity.HasKey(e => e.IdLog).HasName("SISTEMA_Log_Ejecucion_PK");

            entity.ToTable("SISTEMA_Log_Ejecucion");

            entity.Property(e => e.IdLog).HasColumnName("idLog");
            entity.Property(e => e.ConsultaSql)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("consultaSQL");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.FechaLog).HasColumnType("datetime");
            entity.Property(e => e.NumeroRegistros).HasColumnName("numero_registros");
        });

        modelBuilder.Entity<SutAbonos>(entity =>
        {
            entity.HasKey(e => e.Idabono);

            entity.ToTable("SUT_ABONOS");

            entity.HasIndex(e => new { e.Idcliente, e.Ciclo, e.Estado }, "IX_SUT_ABONOS_procesos").HasFillFactor(80);

            entity.Property(e => e.Idabono).HasColumnName("idabono");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(8)
                .HasColumnName("ciclo");
            entity.Property(e => e.Concepto)
                .HasMaxLength(150)
                .HasColumnName("concepto");
            entity.Property(e => e.Destino)
                .HasMaxLength(50)
                .HasColumnName("destino");
            entity.Property(e => e.Duracion)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("duracion");
            entity.Property(e => e.Estado)
                .HasMaxLength(25)
                .HasColumnName("estado");
            entity.Property(e => e.FacturaAbono)
                .HasMaxLength(50)
                .HasColumnName("factura_abono");
            entity.Property(e => e.FechaDesde)
                .HasColumnType("datetime")
                .HasColumnName("fecha_desde");
            entity.Property(e => e.FechaEntrada)
                .HasColumnType("datetime")
                .HasColumnName("fecha_entrada");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fecha_estado");
            entity.Property(e => e.FechaHasta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hasta");
            entity.Property(e => e.FechaHora)
                .HasMaxLength(20)
                .HasColumnName("fecha_hora");
            entity.Property(e => e.Idadmin).HasColumnName("idadmin");
            entity.Property(e => e.Idcliente).HasColumnName("idcliente");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("importe");
            entity.Property(e => e.Linea)
                .HasMaxLength(25)
                .HasColumnName("linea");
            entity.Property(e => e.NoRecep)
                .HasMaxLength(50)
                .HasColumnName("no_recep");
            entity.Property(e => e.RefAbono)
                .HasMaxLength(50)
                .HasColumnName("ref_abono");
            entity.Property(e => e.TipoAbono)
                .HasMaxLength(15)
                .HasColumnName("tipo_abono");
        });

        modelBuilder.Entity<SutAccesosFallidos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SUT_ACCESOS_FALLIDOS_1");

            entity.ToTable("SUT_ACCESOS_FALLIDOS");

            entity.Property(e => e.DireccionIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DireccionIP");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.UsuarioConexion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SutAdministradores>(entity =>
        {
            entity.HasKey(e => e.IdAdministrador);

            entity.ToTable("SUT_ADMINISTRADORES");

            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DatosNavegadorRgpd)
                .HasMaxLength(300)
                .HasColumnName("DatosNavegadorRGPD");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAceptacionRgpd)
                .HasColumnType("datetime")
                .HasColumnName("FechaAceptacionRGPD");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaUltimaConexion).HasColumnType("datetime");
            entity.Property(e => e.Idagente)
                .HasMaxLength(15)
                .HasColumnName("IDAgente");
            entity.Property(e => e.IpaceptacionRgpd)
                .HasMaxLength(15)
                .HasColumnName("IPAceptacionRGPD");
            entity.Property(e => e.Nif)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoAgente).HasMaxLength(15);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.SutAdministradores)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK_SUT_ADMINISTRADORES_Empresas");

            entity.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.SutAdministradores)
                .HasForeignKey(d => d.IdPerfil)
                .HasConstraintName("FK_SUT_ADMINISTRADORES_SUT_PERFILES");
        });

        modelBuilder.Entity<SutAgentes>(entity =>
        {
            entity.HasKey(e => e.IdAgente).HasName("PK_SUT_AGENTES_1");

            entity.ToTable("SUT_AGENTES");

            entity.Property(e => e.IdAgente)
                .ValueGeneratedNever()
                .HasColumnName("idAgente");
            entity.Property(e => e.Captacion)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CodPostal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Desarrollo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaModif).HasColumnType("datetime");
            entity.Property(e => e.ImpCaptacion).HasColumnType("decimal(2, 2)");
            entity.Property(e => e.ImpDesarrollo).HasColumnType("decimal(2, 2)");
            entity.Property(e => e.InfoAdicional)
                .IsUnicode(false)
                .HasColumnName("infoAdicional");
            entity.Property(e => e.Nifagente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIFAgente");
            entity.Property(e => e.NombreAgente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Poblacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelMovil)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SutAsociacionesPerfilUsuario>(entity =>
        {
            entity.ToTable("SUT_ASOCIACIONES_PERFIL_USUARIO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AtrbuserOpc)
                .HasMaxLength(50)
                .HasColumnName("ATRBUSER_OPC");
            entity.Property(e => e.Cif)
                .HasMaxLength(50)
                .HasColumnName("CIF");
            entity.Property(e => e.Cp)
                .HasMaxLength(5)
                .HasColumnName("CP");
            entity.Property(e => e.Direccion).HasMaxLength(250);
            entity.Property(e => e.EmailContacto)
                .HasMaxLength(100)
                .HasColumnName("emailContacto");
            entity.Property(e => e.Estado).HasMaxLength(10);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.NombreComercial).HasMaxLength(250);
            entity.Property(e => e.NotificarAvisosEmail).HasColumnName("NOTIFICAR_AVISOS_EMAIL");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.PersonaContacto).HasMaxLength(250);
            entity.Property(e => e.Poblacion).HasMaxLength(250);
            entity.Property(e => e.Provincia).HasMaxLength(250);
            entity.Property(e => e.RazonSocial).HasMaxLength(250);
            entity.Property(e => e.TextoAviso)
                .HasMaxLength(250)
                .HasColumnName("TEXTO_AVISO");
            entity.Property(e => e.TlfnoContacto).HasMaxLength(50);
        });

        modelBuilder.Entity<SutAtributosColectivo>(entity =>
        {
            entity.HasKey(e => e.Idatrbcolectivo);

            entity.ToTable("SUT_ATRIBUTOS_COLECTIVO");

            entity.HasIndex(e => new { e.Idcolectivo, e.Idusuario, e.Idlinea, e.Perfilusuario, e.ObligatorioAtrb, e.EstadoAtrb, e.FdesdeAtrb, e.FhastaAtrb }, "IX_SUT_ATRIBUTOS_COLECTIVO_procesos").HasFillFactor(80);

            entity.HasIndex(e => new { e.Idusuario, e.Idlinea, e.EstadoAtrb, e.FdesdeAtrb, e.FhastaAtrb }, "IX_SUT_ATRIBUTOS_COLECTIVO_procesos2").HasFillFactor(80);

            entity.HasIndex(e => new { e.Idlinea, e.FdesdeAtrb, e.FhastaAtrb, e.EstadoAtrb }, "IX_SUT_ATRIBUTOS_COLECTIVO_procesos3").HasFillFactor(80);

            entity.HasIndex(e => new { e.Idcolectivo, e.Idusuario, e.Idlinea, e.Perfilusuario, e.NivelAtrb, e.ObligatorioAtrb, e.EstadoAtrb, e.FdesdeAtrb, e.FhastaAtrb }, "IX_SUT_ATRIBUTOS_COLECTIVO_procesos4").HasFillFactor(80);

            entity.Property(e => e.Idatrbcolectivo).HasColumnName("IDATRBCOLECTIVO");
            entity.Property(e => e.CategoriaAtrb)
                .HasMaxLength(25)
                .HasColumnName("CATEGORIA_ATRB");
            entity.Property(e => e.CodfacturacionAtrb)
                .HasMaxLength(25)
                .HasColumnName("CODFACTURACION_ATRB");
            entity.Property(e => e.CodigoAtrb)
                .HasMaxLength(20)
                .HasColumnName("CODIGO_ATRB");
            entity.Property(e => e.DescripcionAtrb).HasColumnName("DESCRIPCION_ATRB");
            entity.Property(e => e.EmisorAtrb)
                .HasMaxLength(5)
                .HasColumnName("EMISOR_ATRB");
            entity.Property(e => e.EstadoAtrb)
                .HasMaxLength(15)
                .HasColumnName("ESTADO_ATRB");
            entity.Property(e => e.FdesdeAtrb)
                .HasColumnType("datetime")
                .HasColumnName("FDESDE_ATRB");
            entity.Property(e => e.FestadoAtrb)
                .HasColumnType("datetime")
                .HasColumnName("FESTADO_ATRB");
            entity.Property(e => e.FhastaAtrb)
                .HasColumnType("datetime")
                .HasColumnName("FHASTA_ATRB");
            entity.Property(e => e.IdFacturaOrigen).HasColumnName("idFacturaOrigen");
            entity.Property(e => e.IdProceso).HasColumnName("idProceso");
            entity.Property(e => e.Idcolectivo).HasColumnName("IDCOLECTIVO");
            entity.Property(e => e.Idlinea).HasColumnName("IDLINEA");
            entity.Property(e => e.IdoperCreaAtrb).HasColumnName("IDOPER_CREA_ATRB");
            entity.Property(e => e.IdoperModifAtrb).HasColumnName("IDOPER_MODIF_ATRB");
            entity.Property(e => e.Idusuario).HasColumnName("IDUSUARIO");
            entity.Property(e => e.LiteralAtrb)
                .HasMaxLength(100)
                .HasColumnName("LITERAL_ATRB");
            entity.Property(e => e.LiteralasociadoAtrb)
                .HasMaxLength(200)
                .HasColumnName("LITERALASOCIADO_ATRB");
            entity.Property(e => e.Nivel4editarAtrb).HasColumnName("NIVEL4EDITAR_ATRB");
            entity.Property(e => e.NivelAtrb)
                .HasMaxLength(15)
                .HasColumnName("NIVEL_ATRB");
            entity.Property(e => e.ObligatorioAtrb).HasColumnName("OBLIGATORIO_ATRB");
            entity.Property(e => e.Param1Atrb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PARAM1_ATRB");
            entity.Property(e => e.Param2Atrb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PARAM2_ATRB");
            entity.Property(e => e.Param3Atrb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PARAM3_ATRB");
            entity.Property(e => e.Perfilusuario)
                .HasMaxLength(1)
                .HasColumnName("PERFILUSUARIO");
            entity.Property(e => e.PermiterepAtrb).HasColumnName("PERMITEREP_ATRB");
            entity.Property(e => e.ProrrateoAtrb).HasColumnName("PRORRATEO_ATRB");
            entity.Property(e => e.TipoAtrb)
                .HasMaxLength(25)
                .HasColumnName("TIPO_ATRB");
            entity.Property(e => e.TraficoincluidoAtrb)
                .HasMaxLength(15)
                .HasColumnName("TRAFICOINCLUIDO_ATRB");
            entity.Property(e => e.ValorAtrb)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("VALOR_ATRB");
        });

        modelBuilder.Entity<SutAtributosTemp>(entity =>
        {
            entity.HasKey(e => e.Idatrbcolectivo);

            entity.ToTable("SUT_ATRIBUTOS_TEMP");

            entity.Property(e => e.Idatrbcolectivo)
                .ValueGeneratedNever()
                .HasColumnName("IDATRBCOLECTIVO");
            entity.Property(e => e.CategoriaAtrb)
                .HasMaxLength(25)
                .HasColumnName("CATEGORIA_ATRB");
            entity.Property(e => e.CodfacturacionAtrb)
                .HasMaxLength(25)
                .HasColumnName("CODFACTURACION_ATRB");
            entity.Property(e => e.CodigoAtrb)
                .HasMaxLength(20)
                .HasColumnName("CODIGO_ATRB");
            entity.Property(e => e.DescripcionAtrb).HasColumnName("DESCRIPCION_ATRB");
            entity.Property(e => e.EmisorAtrb)
                .HasMaxLength(5)
                .HasColumnName("EMISOR_ATRB");
            entity.Property(e => e.EstadoAtrb)
                .HasMaxLength(15)
                .HasColumnName("ESTADO_ATRB");
            entity.Property(e => e.FdesdeAtrb)
                .HasColumnType("datetime")
                .HasColumnName("FDESDE_ATRB");
            entity.Property(e => e.FestadoAtrb)
                .HasColumnType("datetime")
                .HasColumnName("FESTADO_ATRB");
            entity.Property(e => e.FhastaAtrb)
                .HasColumnType("datetime")
                .HasColumnName("FHASTA_ATRB");
            entity.Property(e => e.IdFacturaOrigen).HasColumnName("idFacturaOrigen");
            entity.Property(e => e.IdProceso).HasColumnName("idProceso");
            entity.Property(e => e.Idcolectivo).HasColumnName("IDCOLECTIVO");
            entity.Property(e => e.Idlinea).HasColumnName("IDLINEA");
            entity.Property(e => e.IdoperCreaAtrb).HasColumnName("IDOPER_CREA_ATRB");
            entity.Property(e => e.IdoperModifAtrb).HasColumnName("IDOPER_MODIF_ATRB");
            entity.Property(e => e.Idusuario).HasColumnName("IDUSUARIO");
            entity.Property(e => e.LiteralAtrb)
                .HasMaxLength(100)
                .HasColumnName("LITERAL_ATRB");
            entity.Property(e => e.LiteralasociadoAtrb)
                .HasMaxLength(200)
                .HasColumnName("LITERALASOCIADO_ATRB");
            entity.Property(e => e.Nivel4editarAtrb).HasColumnName("NIVEL4EDITAR_ATRB");
            entity.Property(e => e.NivelAtrb)
                .HasMaxLength(15)
                .HasColumnName("NIVEL_ATRB");
            entity.Property(e => e.ObligatorioAtrb).HasColumnName("OBLIGATORIO_ATRB");
            entity.Property(e => e.Param1Atrb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PARAM1_ATRB");
            entity.Property(e => e.Param2Atrb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PARAM2_ATRB");
            entity.Property(e => e.Param3Atrb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PARAM3_ATRB");
            entity.Property(e => e.Perfilusuario)
                .HasMaxLength(1)
                .HasColumnName("PERFILUSUARIO");
            entity.Property(e => e.PermiterepAtrb).HasColumnName("PERMITEREP_ATRB");
            entity.Property(e => e.ProrrateoAtrb).HasColumnName("PRORRATEO_ATRB");
            entity.Property(e => e.TipoAtrb)
                .HasMaxLength(25)
                .HasColumnName("TIPO_ATRB");
            entity.Property(e => e.TraficoincluidoAtrb)
                .HasMaxLength(15)
                .HasColumnName("TRAFICOINCLUIDO_ATRB");
            entity.Property(e => e.ValorAtrb)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("VALOR_ATRB");
        });

        modelBuilder.Entity<SutAutorizadosFibra>(entity =>
        {
            entity.ToTable("SUT_AUTORIZADOS_FIBRA");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodPostal)
                .HasMaxLength(5)
                .HasColumnName("codPostal");
            entity.Property(e => e.Direccion)
                .HasMaxLength(1000)
                .HasColumnName("direccion");
            entity.Property(e => e.EmailContacto)
                .HasMaxLength(50)
                .HasColumnName("emailContacto");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .HasColumnName("estado");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fechaEstado");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.IdLineaAsociatel)
                .HasMaxLength(25)
                .HasColumnName("idLineaAsociatel");
            entity.Property(e => e.NifAutorizado)
                .HasMaxLength(9)
                .HasColumnName("nifAutorizado");
            entity.Property(e => e.NombreCompletoAutorizado)
                .HasMaxLength(50)
                .HasColumnName("nombreCompletoAutorizado");
            entity.Property(e => e.NumFibra)
                .HasMaxLength(25)
                .HasColumnName("numFibra");
            entity.Property(e => e.NumFijo)
                .HasMaxLength(25)
                .HasColumnName("numFijo");
            entity.Property(e => e.Poblacion)
                .HasMaxLength(50)
                .HasColumnName("poblacion");
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .HasColumnName("provincia");
            entity.Property(e => e.TlfnoContacto)
                .HasMaxLength(9)
                .HasColumnName("tlfnoContacto");
        });

        modelBuilder.Entity<SutAveriasTerminal>(entity =>
        {
            entity.ToTable("SUT_AVERIAS_TERMINAL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodAveria).HasMaxLength(3);
            entity.Property(e => e.DescAveria).HasMaxLength(250);
            entity.Property(e => e.LiteralAveria).HasMaxLength(50);
            entity.Property(e => e.TipoAveria).HasMaxLength(15);
        });

        modelBuilder.Entity<SutAvisos>(entity =>
        {
            entity.HasKey(e => e.Idaviso);

            entity.ToTable("SUT_AVISOS");

            entity.Property(e => e.Idaviso).HasColumnName("IDAviso");
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaHasta).HasColumnType("datetime");
            entity.Property(e => e.Idcolectivo).HasColumnName("IDColectivo");
            entity.Property(e => e.Idoperador).HasColumnName("IDOperador");
            entity.Property(e => e.Idusuario).HasColumnName("IDUsuario");
            entity.Property(e => e.Mensaje).HasMaxLength(1000);
        });

        modelBuilder.Entity<SutCambiosCuentaFacturacionPlanesPrecios>(entity =>
        {
            entity.HasKey(e => e.IdRegistro);

            entity.ToTable("SUT_CambiosCuentaFacturacionPlanesPrecios");

            entity.Property(e => e.CuentaFactAntigua).HasMaxLength(50);
            entity.Property(e => e.CuentaFactNueva).HasMaxLength(50);
            entity.Property(e => e.Estado).HasMaxLength(15);
            entity.Property(e => e.FechaCambioCuentaFacturacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEnvioVf)
                .HasColumnType("datetime")
                .HasColumnName("FechaEnvioVF");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdTicket).HasColumnName("idTicket");
            entity.Property(e => e.PlanPreciosNuevo).HasMaxLength(50);
            entity.Property(e => e.PrecioNetoPlanPreciosNuevo).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<SutCatalogoServicios>(entity =>
        {
            entity.HasKey(e => e.IdCatServ);

            entity.ToTable("SUT_CATALOGO_SERVICIOS");

            entity.Property(e => e.IdCatServ).HasColumnName("ID_CAT_SERV");
            entity.Property(e => e.AtribOpcAlta)
                .HasMaxLength(150)
                .HasColumnName("ATRIB_OPC_ALTA");
            entity.Property(e => e.CatServicio)
                .HasMaxLength(25)
                .HasColumnName("CAT_SERVICIO");
            entity.Property(e => e.CodOper).HasColumnName("COD_OPER");
            entity.Property(e => e.CodPenalizacion)
                .HasMaxLength(100)
                .HasColumnName("COD_PENALIZACION");
            entity.Property(e => e.CodServicio)
                .HasMaxLength(25)
                .HasColumnName("COD_SERVICIO");
            entity.Property(e => e.CodServicioOper)
                .HasMaxLength(25)
                .HasColumnName("COD_SERVICIO_OPER");
            entity.Property(e => e.CompromisoPermanencia).HasColumnName("COMPROMISO_PERMANENCIA");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.DtoColectivo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DTO_COLECTIVO");
            entity.Property(e => e.Estado)
                .HasMaxLength(25)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ALTA");
            entity.Property(e => e.FechaBaja)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_BAJA");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ESTADO");
            entity.Property(e => e.FechaHasta)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HASTA");
            entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");
            entity.Property(e => e.ImporteBrutoOperador)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IMPORTE_BRUTO_OPERADOR");
            entity.Property(e => e.ImporteBrutoOperadorAlta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IMPORTE_BRUTO_OPERADOR_ALTA");
            entity.Property(e => e.ImporteNetoUsuario)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IMPORTE_NETO_USUARIO");
            entity.Property(e => e.ImportePermanencia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IMPORTE_PERMANENCIA");
            entity.Property(e => e.InfoTramites)
                .HasMaxLength(3000)
                .HasColumnName("INFO_TRAMITES");
            entity.Property(e => e.Literal)
                .HasMaxLength(100)
                .HasColumnName("LITERAL");
            entity.Property(e => e.MesesPermanencia).HasColumnName("MESES_PERMANENCIA");
            entity.Property(e => e.Parametros)
                .HasMaxLength(150)
                .HasColumnName("PARAMETROS");
            entity.Property(e => e.ParametrosActivacion).HasColumnName("PARAMETROS_ACTIVACION");
            entity.Property(e => e.PerfilUsuario)
                .HasMaxLength(1)
                .HasColumnName("PERFIL_USUARIO");
            entity.Property(e => e.PlanespreciosDepen)
                .HasMaxLength(100)
                .HasColumnName("PLANESPRECIOS_DEPEN");
            entity.Property(e => e.ServIncomp)
                .HasMaxLength(150)
                .HasColumnName("SERV_INCOMP");
            entity.Property(e => e.TipoActivacion).HasColumnName("TIPO_ACTIVACION");
            entity.Property(e => e.TipoDeCobro)
                .HasMaxLength(1)
                .HasColumnName("TIPO_DE_COBRO");
            entity.Property(e => e.TipoPermanencia)
                .HasMaxLength(1)
                .HasColumnName("TIPO_PERMANENCIA");
        });

        modelBuilder.Entity<SutClientesUsuariosFacturas>(entity =>
        {
            entity.HasKey(e => e.IdFactura);

            entity.ToTable("SUT_CLIENTES_USUARIOS_FACTURAS");

            entity.Property(e => e.IdFactura).ValueGeneratedNever();
            entity.Property(e => e.IdClienteFac).HasColumnName("IdClienteFAC");
            entity.Property(e => e.IdProceso).HasColumnName("idProceso");
            entity.Property(e => e.IdUsuarioFac).HasColumnName("IdUsuarioFAC");
            entity.Property(e => e.NumFactura)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteFacNavigation).WithMany(p => p.SutClientesUsuariosFacturas)
                .HasForeignKey(d => d.IdClienteFac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUT_CLIENTES_USUARIOS_FACTURAS_Empresas");

            entity.HasOne(d => d.IdFacturaNavigation).WithOne(p => p.SutClientesUsuariosFacturas)
                .HasForeignKey<SutClientesUsuariosFacturas>(d => d.IdFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUT_CLIENTES_USUARIOS_FACTURAS_SUT_FACTURAS");
        });

        modelBuilder.Entity<SutCompromisos>(entity =>
        {
            entity.HasKey(e => e.IdCompromiso);

            entity.ToTable("SUT_COMPROMISOS");

            entity.Property(e => e.ComentarioBaja)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Emisor).HasMaxLength(10);
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaDesde).HasColumnType("datetime");
            entity.Property(e => e.FechaExencion).HasColumnType("datetime");
            entity.Property(e => e.FechaHasta).HasColumnType("datetime");
            entity.Property(e => e.IdPosventa).HasColumnName("idPosventa");
            entity.Property(e => e.ImporteExencion).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImporteTdatos)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ImporteTDatos");
            entity.Property(e => e.ImporteTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MesesTramoFijo).HasColumnName("MESES_TRAMO_FIJO");
            entity.Property(e => e.ModoPenal).HasMaxLength(1);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdLineaNavigation).WithMany(p => p.SutCompromisos)
                .HasForeignKey(d => d.IdLinea)
                .HasConstraintName("FK_SUT_COMPROMISOS_SUT_LINEAS");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.SutCompromisos)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK_SUT_COMPROMISOS_SUT_SERVICIOS");

            entity.HasOne(d => d.IdTerminalNavigation).WithMany(p => p.SutCompromisos)
                .HasForeignKey(d => d.IdTerminal)
                .HasConstraintName("FK_SUT_COMPROMISOS_SUT_TERMINALES");
        });

        modelBuilder.Entity<SutConfiguracion>(entity =>
        {
            entity.ToTable("SUT_CONFIGURACION");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Valor).HasMaxLength(255);
        });

        modelBuilder.Entity<SutConstantes>(entity =>
        {
            entity.HasKey(e => e.IdConstante);

            entity.ToTable("SUT_CONSTANTES");

            entity.HasIndex(e => new { e.Nombre, e.CodOperador }, "IX_SUT_CONSTANTES_procesos").HasFillFactor(80);

            entity.Property(e => e.CodOperador).HasColumnName("codOperador");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor).IsUnicode(false);
        });

        modelBuilder.Entity<SutContactosVodafone>(entity =>
        {
            entity.HasKey(e => e.IdComercialvd).HasName("PK_CONTACTOS_VODAFONE");

            entity.ToTable("SUT_CONTACTOS_VODAFONE");

            entity.Property(e => e.IdComercialvd).HasColumnName("ID_COMERCIALVD");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Estado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ALTA");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ESTADO");
            entity.Property(e => e.Movil)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("MOVIL");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Sfid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SFID");
        });

        modelBuilder.Entity<SutControlAcceso>(entity =>
        {
            entity.HasKey(e => new { e.IdAdmin, e.IdColectivo });

            entity.ToTable("SUT_CONTROL_ACCESO");

            entity.Property(e => e.IdAdmin).HasColumnName("idAdmin");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
        });

        modelBuilder.Entity<SutControlTerminales>(entity =>
        {
            entity.HasKey(e => new { e.Idcliente, e.Idlinea, e.Imei });

            entity.ToTable("SUT_CONTROL_TERMINALES");

            entity.Property(e => e.Idcliente).HasColumnName("IDCLIENTE");
            entity.Property(e => e.Idlinea).HasColumnName("IDLINEA");
            entity.Property(e => e.Imei)
                .HasMaxLength(20)
                .HasColumnName("IMEI");
            entity.Property(e => e.CicloLiq)
                .HasMaxLength(10)
                .HasColumnName("CICLO_LIQ");
            entity.Property(e => e.Clave)
                .HasMaxLength(500)
                .HasColumnName("CLAVE");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(250)
                .HasColumnName("COMENTARIOS");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .HasColumnName("ESTADO");
            entity.Property(e => e.EstadoLiq)
                .HasMaxLength(50)
                .HasColumnName("ESTADO_LIQ");
            entity.Property(e => e.FEstado)
                .HasColumnType("datetime")
                .HasColumnName("F_ESTADO");
            entity.Property(e => e.FPublicacion)
                .HasColumnType("datetime")
                .HasColumnName("F_PUBLICACION");
            entity.Property(e => e.ModoFinanciacion).HasColumnName("MODO_FINANCIACION");
            entity.Property(e => e.NOrden).HasColumnName("N_ORDEN");
            entity.Property(e => e.NPedidoOp)
                .HasMaxLength(50)
                .HasColumnName("N_PEDIDO_OP");
            entity.Property(e => e.PCompra)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("P_COMPRA");
            entity.Property(e => e.PCompraEurvf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("P_COMPRA_EURVF");
            entity.Property(e => e.PVenta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("P_VENTA");
            entity.Property(e => e.PlazoFinanciacion).HasColumnName("PLAZO_FINANCIACION");
            entity.Property(e => e.Terminal)
                .HasMaxLength(200)
                .HasColumnName("TERMINAL");
            entity.Property(e => e.TipoPedido)
                .HasMaxLength(50)
                .HasColumnName("TIPO_PEDIDO");
        });

        modelBuilder.Entity<SutConversorIdadsl>(entity =>
        {
            entity.ToTable("SUT_CONVERSOR_IDADSL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodigoAdslSg)
                .HasMaxLength(25)
                .HasColumnName("CODIGO_ADSL_SG");
            entity.Property(e => e.CodigoAdslVf)
                .HasMaxLength(25)
                .HasColumnName("CODIGO_ADSL_VF");
            entity.Property(e => e.Estado)
                .HasMaxLength(15)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Idcolectivo).HasColumnName("IDCOLECTIVO");
        });

        modelBuilder.Entity<SutCuotasVodafone>(entity =>
        {
            entity.HasKey(e => new { e.IdColectivo, e.CodOperador, e.CodCuenta, e.Fechadesde });

            entity.ToTable("SUT_CuotasVodafone");

            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.CodOperador)
                .HasMaxLength(25)
                .HasColumnName("codOperador");
            entity.Property(e => e.CodCuenta)
                .HasMaxLength(15)
                .HasColumnName("codCuenta");
            entity.Property(e => e.Fechadesde)
                .HasColumnType("datetime")
                .HasColumnName("FECHADESDE");
            entity.Property(e => e.DtoOperador).HasColumnName("dtoOperador");
            entity.Property(e => e.Fechahasta)
                .HasColumnType("datetime")
                .HasColumnName("FECHAHASTA");
            entity.Property(e => e.LiteralAsociado)
                .HasMaxLength(100)
                .HasColumnName("literalAsociado");
            entity.Property(e => e.PrecioBruto)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("precioBruto");
            entity.Property(e => e.PrecioNeto)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("precioNeto");
            entity.Property(e => e.TipoTarifa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoTarifa");
        });

        modelBuilder.Entity<SutDescargas>(entity =>
        {
            entity.HasKey(e => e.IdDescarga);

            entity.ToTable("SUT_DESCARGAS");

            entity.Property(e => e.IdDescarga).HasColumnName("idDescarga");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FactOtm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Fact_OTM");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaFinDescarga).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioDescarga).HasColumnType("datetime");
            entity.Property(e => e.FechaUltimaDescarga).HasColumnType("datetime");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.IdentificadorDescarga)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IpUltimaDescarga)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.NombreFichero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumDescargas).HasDefaultValue(0);
        });

        modelBuilder.Entity<SutDetalleTelefonoFactura>(entity =>
        {
            entity.HasKey(e => e.IdDetalle);

            entity.ToTable("SUT_DETALLE_TELEFONO_FACTURA");

            entity.HasIndex(e => new { e.IdFactura, e.IdLinea }, "IX_SUT_DETALLE_TELEFONO_FACTURA_IDFACTURA_IDLINEA").HasFillFactor(80);

            entity.Property(e => e.Destino)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DuracionLlamada).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Emisor)
                .HasMaxLength(5)
                .HasColumnName("EMISOR");
            entity.Property(e => e.FechaDesde).HasMaxLength(10);
            entity.Property(e => e.FechaHasta).HasMaxLength(10);
            entity.Property(e => e.FechaHora)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImporteNeto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NumTelefRecep)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumTelefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarifa)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TipoDetalle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VolumenDatos).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.SutDetalleTelefonoFactura)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUT_DETALLE_TELEFONO_FACTURA_IDFACTURA");
        });

        modelBuilder.Entity<SutDireccionesClientes>(entity =>
        {
            entity.HasKey(e => e.IdDireccion);

            entity.ToTable("SUT_DIRECCIONES_CLIENTES");

            entity.Property(e => e.CodPostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Poblacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.SutDireccionesClientes)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK_SUT_DIRECCIONES_CLIENTES_Empresas");
        });

        modelBuilder.Entity<SutDireccionesUsuarios>(entity =>
        {
            entity.HasKey(e => e.IdDireccion);

            entity.ToTable("SUT_DIRECCIONES_USUARIOS");

            entity.HasIndex(e => e.IdUsuario, "IX_SUT_DIRECCIONES_USUARIOS_procesos").HasFillFactor(80);

            entity.Property(e => e.CodPostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Poblacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.SutDireccionesUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUT_DIRECCIONES_USUARIOS_SUT_USUARIOS");
        });

        modelBuilder.Entity<SutDocumentacion>(entity =>
        {
            entity.HasKey(e => e.IdDocumento);

            entity.ToTable("SUT_DOCUMENTACION");

            entity.Property(e => e.IdDocumento).HasColumnName("idDocumento");
            entity.Property(e => e.AmbitoDocumento)
                .HasMaxLength(50)
                .HasColumnName("ambitoDocumento");
            entity.Property(e => e.CodOperador).HasColumnName("codOperador");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fichero)
                .HasMaxLength(255)
                .HasColumnName("fichero");
            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.NivelAcceso).HasColumnName("nivelAcceso");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .HasColumnName("tipoDocumento");
        });

        modelBuilder.Entity<SutFacturas>(entity =>
        {
            entity.HasKey(e => e.IdFactura);

            entity.ToTable("SUT_FACTURAS");

            entity.HasIndex(e => e.IdColectivo, "IX_SUT_FACTURAS_fecha").HasFillFactor(80);

            entity.HasIndex(e => new { e.IdProceso, e.IdColectivo }, "IX_SUT_FACTURAS_procesos").HasFillFactor(80);

            entity.Property(e => e.BaseImponible).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CodPostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ComentariosPagos).HasColumnName("comentariosPagos");
            entity.Property(e => e.Direccion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.EnlaceGenerado).HasMaxLength(2);
            entity.Property(e => e.EstadoNorma19).HasMaxLength(50);
            entity.Property(e => e.FactOtm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Fact_OTM");
            entity.Property(e => e.FechaCargo).HasColumnType("datetime");
            entity.Property(e => e.FechaFactura).HasColumnType("datetime");
            entity.Property(e => e.FechaFin)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FicheroNorma19).HasMaxLength(50);
            entity.Property(e => e.Generacion).HasMaxLength(1);
            entity.Property(e => e.IdAsociacionPerfilUsuario).HasColumnName("idAsociacionPerfilUsuario");
            entity.Property(e => e.IdClienteUsuario).HasColumnName("idClienteUsuario");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.IdProceso).HasColumnName("idProceso");
            entity.Property(e => e.ImporteBruto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImportePagos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importePagos");
            entity.Property(e => e.ImportePtePago)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importePtePago");
            entity.Property(e => e.ImportePuntos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Iva).HasColumnName("IVA");
            entity.Property(e => e.NombreBanco)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumCuenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumFactura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Poblacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoFactura).HasMaxLength(50);
            entity.Property(e => e.TmImporteacuenta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_importeacuenta");
            entity.Property(e => e.TmImportecomision)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_importecomision");
            entity.Property(e => e.TmMesesPlazo).HasColumnName("tm_mesesPlazo");
            entity.Property(e => e.TmModoFin).HasColumnName("tm_modoFin");
            entity.Property(e => e.TmPreciocoste1)
                .HasComment("Precio coste Operador")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_preciocoste1");
            entity.Property(e => e.TmPreciocoste2)
                .HasComment("Precio coste Grupo Facturacion")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_preciocoste2");
            entity.Property(e => e.TmPrecioventa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_precioventa");
            entity.Property(e => e.TotalDescuentos).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalFactura).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<SutFacturasPfm>(entity =>
        {
            entity.HasKey(e => e.IdFactura);

            entity.ToTable("SUT_FACTURAS_PFM");

            entity.Property(e => e.BaseImponible).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CodPostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ComentariosPagos).HasColumnName("comentariosPagos");
            entity.Property(e => e.Direccion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.EnlaceGenerado).HasMaxLength(2);
            entity.Property(e => e.EstadoNorma19).HasMaxLength(50);
            entity.Property(e => e.FactOtm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Fact_OTM");
            entity.Property(e => e.FechaCargo).HasColumnType("datetime");
            entity.Property(e => e.FechaFactura).HasColumnType("datetime");
            entity.Property(e => e.FechaFin)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FicheroNorma19).HasMaxLength(50);
            entity.Property(e => e.Generacion).HasMaxLength(1);
            entity.Property(e => e.IdAsociacionPerfilUsuario).HasColumnName("idAsociacionPerfilUsuario");
            entity.Property(e => e.IdClienteUsuario).HasColumnName("idClienteUsuario");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.IdProceso).HasColumnName("idProceso");
            entity.Property(e => e.ImporteBruto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImportePagos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importePagos");
            entity.Property(e => e.ImportePtePago)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importePtePago");
            entity.Property(e => e.ImportePuntos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Iva).HasColumnName("IVA");
            entity.Property(e => e.NombreBanco)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumCuenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumFactura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Poblacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoFactura).HasMaxLength(50);
            entity.Property(e => e.TmImporteacuenta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_importeacuenta");
            entity.Property(e => e.TmImportecomision)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_importecomision");
            entity.Property(e => e.TmMesesPlazo).HasColumnName("tm_mesesPlazo");
            entity.Property(e => e.TmModoFin).HasColumnName("tm_modoFin");
            entity.Property(e => e.TmPreciocoste1)
                .HasComment("Precio coste Operador")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_preciocoste1");
            entity.Property(e => e.TmPreciocoste2)
                .HasComment("Precio coste Grupo Facturacion")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_preciocoste2");
            entity.Property(e => e.TmPrecioventa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_precioventa");
            entity.Property(e => e.TotalDescuentos).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalFactura).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<SutFichAdjuntos>(entity =>
        {
            entity.HasKey(e => e.IdFichero);

            entity.ToTable("SUT_FICH_ADJUNTOS");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.NombreFichero)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RutaServidor)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.HasOne(d => d.IdLineaNavigation).WithMany(p => p.SutFichAdjuntos)
                .HasForeignKey(d => d.IdLinea)
                .HasConstraintName("FK_SUT_FICH_ADJUNTOS_SUT_LINEAS");

            entity.HasOne(d => d.IdPeticionNavigation).WithMany(p => p.SutFichAdjuntos)
                .HasForeignKey(d => d.IdPeticion)
                .HasConstraintName("FK_SUT_FICH_ADJUNTOS_SUT_PETICIONES_INCIDENCIAS");
        });

        modelBuilder.Entity<SutFiltrosListadoAvanzado>(entity =>
        {
            entity.HasKey(e => e.IdFiltro);

            entity.ToTable("SUT_FiltrosListadoAvanzado");

            entity.Property(e => e.IdFiltro).HasColumnName("idFiltro");
            entity.Property(e => e.Campos)
                .HasMaxLength(4000)
                .HasColumnName("campos");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .HasColumnName("estado");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fechaAlta");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fechaEstado");
            entity.Property(e => e.Filtros)
                .HasMaxLength(4000)
                .HasColumnName("filtros");
            entity.Property(e => e.IdAdminCreador).HasColumnName("idAdminCreador");
            entity.Property(e => e.IdAdminModif).HasColumnName("idAdminModif");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.NombreFiltro)
                .HasMaxLength(100)
                .HasColumnName("nombreFiltro");
        });

        modelBuilder.Entity<SutGenerarFacturas>(entity =>
        {
            entity.HasKey(e => e.IdgenerarFactura);

            entity.ToTable("SUT_GENERAR_FACTURAS");

            entity.Property(e => e.IdgenerarFactura).HasColumnName("IDGenerarFactura");
            entity.Property(e => e.Estado).HasMaxLength(15);
            entity.Property(e => e.FechaEntrada).HasColumnType("datetime");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.Idcolectivo).HasColumnName("IDColectivo");
            entity.Property(e => e.Idfactura).HasColumnName("IDFactura");
            entity.Property(e => e.Ruta).HasMaxLength(1000);
        });

        modelBuilder.Entity<SutGrupos>(entity =>
        {
            entity.HasKey(e => e.IdGrupo);

            entity.ToTable("SUT_GRUPOS");

            entity.Property(e => e.IdGrupo).ValueGeneratedNever();
            entity.Property(e => e.Banco).HasMaxLength(100);
            entity.Property(e => e.Cif)
                .HasMaxLength(9)
                .HasColumnName("CIF");
            entity.Property(e => e.Cp)
                .HasMaxLength(5)
                .HasColumnName("CP");
            entity.Property(e => e.Direccion).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.InfoAdicional).HasMaxLength(1000);
            entity.Property(e => e.Iniciales).HasMaxLength(5);
            entity.Property(e => e.NumCuenta).HasMaxLength(100);
            entity.Property(e => e.Poblacion).HasMaxLength(500);
            entity.Property(e => e.Provincia).HasMaxLength(500);
            entity.Property(e => e.RazonSocial).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(50);
        });

        modelBuilder.Entity<SutHistComentariosLineas>(entity =>
        {
            entity.HasKey(e => e.IdHistorico);

            entity.ToTable("SUT_HIST_COMENTARIOS_LINEAS");

            entity.Property(e => e.IdHistorico).HasColumnName("idHistorico");
            entity.Property(e => e.Comentario).HasMaxLength(4000);
            entity.Property(e => e.IdAdminComentario).HasColumnName("idAdminComentario");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.IdLinea).HasColumnName("idLinea");
            entity.Property(e => e.IdPosventa).HasColumnName("idPosventa");
            entity.Property(e => e.NumTelefono)
                .HasMaxLength(25)
                .HasColumnName("numTelefono");
            entity.Property(e => e.Origen)
                .HasMaxLength(25)
                .HasColumnName("origen");
            entity.Property(e => e.TipoComentario)
                .HasMaxLength(9)
                .HasColumnName("tipoComentario");
        });

        modelBuilder.Entity<SutHistModifsUsuario>(entity =>
        {
            entity.HasKey(e => e.IdHistoricoUsuario);

            entity.ToTable("SUT_HIST_MODIFS_USUARIO");

            entity.Property(e => e.Cambios)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaModif).HasColumnType("datetime");
            entity.Property(e => e.IdAdminHis).HasColumnName("IdAdminHIS");
            entity.Property(e => e.IdUsuarioHis).HasColumnName("IdUsuarioHIS");
            entity.Property(e => e.TipoModif)
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAdminHisNavigation).WithMany(p => p.SutHistModifsUsuario)
                .HasForeignKey(d => d.IdAdminHis)
                .HasConstraintName("FK_SUT_HIST_MODIFS_USUARIO_SUT_ADMINISTRADORES");

            entity.HasOne(d => d.IdUsuarioHisNavigation).WithMany(p => p.SutHistModifsUsuario)
                .HasForeignKey(d => d.IdUsuarioHis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUT_HIST_MODIFS_USUARIO_SUT_USUARIOS");
        });

        modelBuilder.Entity<SutHistPeticiones>(entity =>
        {
            entity.HasKey(e => e.IdHistorial);

            entity.ToTable("SUT_HIST_PETICIONES");

            entity.Property(e => e.Comentario)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.FechaModif).HasColumnType("datetime");
            entity.Property(e => e.IdAdminHis).HasColumnName("IdAdminHIS");
            entity.Property(e => e.TipoAlta)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAdminHisNavigation).WithMany(p => p.SutHistPeticiones)
                .HasForeignKey(d => d.IdAdminHis)
                .HasConstraintName("FK_SUT_HIST_PETICIONES_SUT_ADMINISTRADORES");

            entity.HasOne(d => d.IdPeticionNavigation).WithMany(p => p.SutHistPeticiones)
                .HasForeignKey(d => d.IdPeticion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUT_HIST_PETICIONES_SUT_PETICIONES_INCIDENCIAS");
        });

        modelBuilder.Entity<SutIncidRefacturacion>(entity =>
        {
            entity.ToTable("SUT_INCID_REFACTURACION");

            entity.HasIndex(e => new { e.IdProceso, e.Tipo }, "IX_SUT_INCID_REFACTURACION_procesos").HasFillFactor(80);

            entity.HasIndex(e => new { e.IdCliente, e.FactOtm, e.Tipo, e.Objeto, e.Valor }, "IX_SUT_INCID_REFACTURACION_procesos2").HasFillFactor(80);

            entity.Property(e => e.Ciclo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.FactOtm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Fact_OTM");
            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.IdProceso).HasColumnName("idProceso");
            entity.Property(e => e.Objeto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SutIpsBloqueadas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SUT_ACCESOS_FALLIDOS");

            entity.ToTable("SUT_IPS_BLOQUEADAS");

            entity.Property(e => e.DireccionIp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DireccionIP");
            entity.Property(e => e.FechaUltimoAcceso).HasColumnType("datetime");
            entity.Property(e => e.UsuarioConexion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SutLineas>(entity =>
        {
            entity.HasKey(e => e.IdLinea);

            entity.ToTable("SUT_LINEAS");

            entity.HasIndex(e => e.IdUsuarioLin, "IX_SUT_LINEAS_procesos").HasFillFactor(80);

            entity.Property(e => e.Alias).HasMaxLength(12);
            entity.Property(e => e.BloqueoLinea).HasColumnName("BLOQUEO_LINEA");
            entity.Property(e => e.ComentarioBloqueo)
                .HasMaxLength(2000)
                .HasColumnName("COMENTARIO_BLOQUEO");
            entity.Property(e => e.CuentaMaestraFibra)
                .HasMaxLength(25)
                .HasColumnName("cuentaMaestraFibra");
            entity.Property(e => e.EsPcPrincipal).HasColumnName("ES_PC_PRINCIPAL");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExtNumTelefono)
                .HasMaxLength(9)
                .HasColumnName("extNumTelefono");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.Franquicia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FranquiciaMax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IdAutorizadoFibra).HasColumnName("idAutorizadoFibra");
            entity.Property(e => e.IdCatpc).HasColumnName("ID_CATPC");
            entity.Property(e => e.IdLineaAsociatel)
                .HasMaxLength(25)
                .HasColumnName("idLineaAsociatel");
            entity.Property(e => e.IdLineaVinculada).HasColumnName("idLineaVinculada");
            entity.Property(e => e.IdNumpc).HasColumnName("ID_NUMPC");
            entity.Property(e => e.IdUsuarioLin).HasColumnName("IdUsuarioLIN");
            entity.Property(e => e.ImporteFianza).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImportePendiente).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InfoAdicional)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.LimiteConsumo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MargenColectivo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MotivoBaja)
                .HasMaxLength(15)
                .HasColumnName("MOTIVO_BAJA");
            entity.Property(e => e.NumContratoTrastienda)
                .HasMaxLength(25)
                .HasColumnName("numContratoTrastienda");
            entity.Property(e => e.NumTelefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumTelefono2).HasMaxLength(25);
            entity.Property(e => e.Operador)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Origen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoLinea)
                .HasMaxLength(10)
                .HasColumnName("tipoLinea");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.SutLineas)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUT_LINEAS_Empresas");

            entity.HasOne(d => d.IdUsuarioLinNavigation).WithMany(p => p.SutLineas)
                .HasForeignKey(d => d.IdUsuarioLin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUT_LINEAS_SUT_USUARIOS");
        });

        modelBuilder.Entity<SutMovimientosEura>(entity =>
        {
            entity.HasKey(e => e.IdOperacion);

            entity.ToTable("SUT_MOVIMIENTOS_EURA");

            entity.Property(e => e.IdOperacion).HasColumnName("idOperacion");
            entity.Property(e => e.DescOperacion)
                .HasMaxLength(1000)
                .HasColumnName("descOperacion");
            entity.Property(e => e.FechaMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("fechaMovimiento");
            entity.Property(e => e.IdAdmin).HasColumnName("idAdmin");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.IdPosventa).HasColumnName("idPosventa");
            entity.Property(e => e.IdProceso).HasColumnName("idProceso");
            entity.Property(e => e.ImporteEura).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Tipo).HasMaxLength(1);
        });

        modelBuilder.Entity<SutNorma19>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("SUT_NORMA19");

            entity.Property(e => e.Idregistro).HasColumnName("IDRegistro");
            entity.Property(e => e.Bicacreedor)
                .HasMaxLength(11)
                .HasColumnName("BICAcreedor");
            entity.Property(e => e.CifOrdenante).HasMaxLength(50);
            entity.Property(e => e.CodPostalFactura).HasMaxLength(5);
            entity.Property(e => e.DireccionFactura).HasMaxLength(1000);
            entity.Property(e => e.FactOtm)
                .HasMaxLength(250)
                .HasColumnName("Fact_OTM");
            entity.Property(e => e.FechaMandato).HasColumnType("datetime");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.NifSocio).HasMaxLength(50);
            entity.Property(e => e.NombreColectivo).HasMaxLength(50);
            entity.Property(e => e.NombreOrdenante).HasMaxLength(50);
            entity.Property(e => e.NombreSocio).HasMaxLength(150);
            entity.Property(e => e.NumCuentaOrdenante).HasMaxLength(50);
            entity.Property(e => e.NumCuentaSocio).HasMaxLength(50);
            entity.Property(e => e.NumFactura).HasMaxLength(50);
            entity.Property(e => e.NumPago).HasColumnName("numPago");
            entity.Property(e => e.PoblacionFactura).HasMaxLength(50);
            entity.Property(e => e.RefMandato).HasMaxLength(50);
            entity.Property(e => e.SufijoOrdenante).HasMaxLength(3);
            entity.Property(e => e.SumatorioTotalFactura).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TipoRecibo)
                .HasMaxLength(10)
                .HasColumnName("tipoRecibo");
            entity.Property(e => e.TotalFactura).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<SutNumerosEspeciales>(entity =>
        {
            entity.HasKey(e => e.IdNum);

            entity.ToTable("SUT_NUMEROS_ESPECIALES");

            entity.Property(e => e.IdNum).HasColumnName("ID_NUM");
            entity.Property(e => e.NumEspecial)
                .HasMaxLength(50)
                .HasColumnName("NUM_ESPECIAL");
        });

        modelBuilder.Entity<SutPagosFactura>(entity =>
        {
            entity.HasKey(e => e.IdPago);

            entity.ToTable("SUT_PAGOS_FACTURA");

            entity.Property(e => e.IdPago).HasColumnName("idPago");
            entity.Property(e => e.CodPago)
                .HasMaxLength(25)
                .HasColumnName("codPago");
            entity.Property(e => e.ConceptoPago)
                .HasMaxLength(100)
                .HasColumnName("conceptoPago");
            entity.Property(e => e.IdFactura).HasColumnName("idFactura");
            entity.Property(e => e.IdFacturaOrigenPago).HasColumnName("idFacturaOrigenPago");
            entity.Property(e => e.IdLinea).HasColumnName("idLinea");
            entity.Property(e => e.ImportePago)
                .HasComment("Total pago, impuestos incluidos (si lleva)")
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("importePago");
            entity.Property(e => e.NumLinea)
                .HasMaxLength(15)
                .HasColumnName("numLinea");
            entity.Property(e => e.NumPago)
                .HasComment("Numero de orden del pago")
                .HasColumnName("numPago");
            entity.Property(e => e.PlazosPago)
                .HasComment("Numero de plazos incluidos en el pago (por ej. al precipitar)")
                .HasColumnName("plazosPago");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(15)
                .HasComment("Cuota Normal, Cuota Precipitada")
                .HasColumnName("tipoPago");
            entity.Property(e => e.TotalPlazos).HasComment("Total de Plazos");
        });

        modelBuilder.Entity<SutPenalizaciones>(entity =>
        {
            entity.ToTable("SUT_PENALIZACIONES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DescripPenal)
                .HasMaxLength(250)
                .HasColumnName("DESCRIP_PENAL");
            entity.Property(e => e.Emisor).HasMaxLength(10);
            entity.Property(e => e.IdColectivo).HasColumnName("ID_COLECTIVO");
            entity.Property(e => e.ImportePenal)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE_PENAL");
            entity.Property(e => e.MesesPenal).HasColumnName("MESES_PENAL");
            entity.Property(e => e.MesesTramoFijo).HasColumnName("MESES_TRAMO_FIJO");
            entity.Property(e => e.ModoPenal)
                .HasMaxLength(1)
                .HasColumnName("MODO_PENAL");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.TipoPenal)
                .HasMaxLength(50)
                .HasColumnName("TIPO_PENAL");
        });

        modelBuilder.Entity<SutPerfilasociacionUsuario>(entity =>
        {
            entity.HasKey(e => e.IdPerfilUsuario);

            entity.ToTable("SUT_PERFILASOCIACION_USUARIO");

            entity.Property(e => e.IdPerfilUsuario).HasColumnName("idPerfilUsuario");
            entity.Property(e => e.BolsaEura)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BOLSA_EURA");
            entity.Property(e => e.CodPerfil)
                .HasMaxLength(3)
                .HasColumnName("codPerfil");
            entity.Property(e => e.DescPerfil)
                .HasMaxLength(50)
                .HasColumnName("descPerfil");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.FidelizacionEura).HasColumnName("FIDELIZACION_EURA");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.LiteralPerfil)
                .HasMaxLength(20)
                .HasColumnName("literalPerfil");
            entity.Property(e => e.LiteralPerfilparaComunicaciones)
                .HasMaxLength(500)
                .HasColumnName("literalPerfilparaComunicaciones");
            entity.Property(e => e.NOrden).HasColumnName("nOrden");
            entity.Property(e => e.TextoAviso)
                .HasMaxLength(250)
                .HasColumnName("textoAviso");
        });

        modelBuilder.Entity<SutPerfiles>(entity =>
        {
            entity.HasKey(e => e.IdPerfil);

            entity.ToTable("SUT_PERFILES");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombrePerfil)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SutPeticionesIncidencias>(entity =>
        {
            entity.HasKey(e => e.IdPeticion);

            entity.ToTable("SUT_PETICIONES_INCIDENCIAS");

            entity.Property(e => e.Asunto).HasMaxLength(250);
            entity.Property(e => e.ComentarioCierre)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CompromisosAsociados).HasMaxLength(100);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaEnvio).HasColumnType("datetime");
            entity.Property(e => e.IdAdminPet).HasColumnName("IdAdminPET");
            entity.Property(e => e.IdClientePet).HasColumnName("IdClientePET");
            entity.Property(e => e.IdOperadorAsignado).HasColumnName("idOperadorAsignado");
            entity.Property(e => e.IdUsuarioPet).HasColumnName("IdUsuarioPET");
            entity.Property(e => e.InfoTramites).HasMaxLength(3000);
            entity.Property(e => e.Prioridad)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TipoAlta)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAdminPetNavigation).WithMany(p => p.SutPeticionesIncidencias)
                .HasForeignKey(d => d.IdAdminPet)
                .HasConstraintName("FK_SUT_PETICIONES_INCIDENCIAS_SUT_ADMINISTRADORES");

            entity.HasOne(d => d.IdClientePetNavigation).WithMany(p => p.SutPeticionesIncidencias)
                .HasForeignKey(d => d.IdClientePet)
                .HasConstraintName("FK_SUT_PETICIONES_INCIDENCIAS_Empresas");

            entity.HasOne(d => d.IdLineaNavigation).WithMany(p => p.SutPeticionesIncidencias)
                .HasForeignKey(d => d.IdLinea)
                .HasConstraintName("FK_SUT_PETICIONES_INCIDENCIAS_SUT_LINEAS");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.SutPeticionesIncidencias)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK_SUT_PETICIONES_INCIDENCIAS_SUT_SERVICIOS");

            entity.HasOne(d => d.IdUsuarioPetNavigation).WithMany(p => p.SutPeticionesIncidencias)
                .HasForeignKey(d => d.IdUsuarioPet)
                .HasConstraintName("FK_SUT_PETICIONES_INCIDENCIAS_SUT_USUARIOS");
        });

        modelBuilder.Entity<SutProductosVbp>(entity =>
        {
            entity.HasKey(e => e.IdPid);

            entity.ToTable("SUT_PRODUCTOS_VBP");

            entity.Property(e => e.IdPid).HasColumnName("id_pid");
            entity.Property(e => e.EstadoPVbp)
                .HasMaxLength(10)
                .HasColumnName("estado_p_vbp");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fecha_estado");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.ProductId)
                .HasMaxLength(20)
                .HasColumnName("product_id");
            entity.Property(e => e.ServiceDesc)
                .HasMaxLength(1024)
                .HasColumnName("service_desc");
            entity.Property(e => e.ServiceId)
                .HasMaxLength(20)
                .HasColumnName("service_id");
        });

        modelBuilder.Entity<SutPromociones>(entity =>
        {
            entity.HasKey(e => e.IdPromocion);

            entity.ToTable("SUT_PROMOCIONES");

            entity.Property(e => e.IdPromocion).HasColumnName("idPromocion");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.Imagen).HasMaxLength(1000);
            entity.Property(e => e.Texto).HasMaxLength(1000);
            entity.Property(e => e.Url)
                .HasMaxLength(1000)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<SutPuntos>(entity =>
        {
            entity.HasKey(e => e.IdOperacion).HasName("PK_SUT_PUNTOS_1");

            entity.ToTable("SUT_PUNTOS");

            entity.Property(e => e.DescOperacion).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.ImportePuntos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SutRefacturacion>(entity =>
        {
            entity.HasKey(e => e.IdProceso);

            entity.ToTable("SUT_REFACTURACION");

            entity.Property(e => e.IdProceso).HasColumnName("idProceso");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FactOtm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Fact_OTM");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.ImporteAbonosSac)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Importe_AbonosSAC");
            entity.Property(e => e.ImporteBolsaEura)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Importe_BolsaEura");
            entity.Property(e => e.ImporteCorreoPostal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Importe_CorreoPostal");
            entity.Property(e => e.ImporteCosteServicio)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Importe_CosteServicio");
            entity.Property(e => e.ImporteCuotasTf)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Importe_CuotasTF");
            entity.Property(e => e.ImporteFacturaOtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Importe_FacturaOTM");
            entity.Property(e => e.ImporteFraSigestel)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Importe_FraSigestel");
            entity.Property(e => e.ImporteLineasSac)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Importe_LineasSAC");
            entity.Property(e => e.ImporteRefacturado)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Importe_Refacturado");
            entity.Property(e => e.ImporteRefacturadoColectivo)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Importe_RefacturadoColectivo");
            entity.Property(e => e.ImporteRefacturadoSocios)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Importe_RefacturadoSocios");
            entity.Property(e => e.ImporteTotalEmitido)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Importe_TotalEmitido");
            entity.Property(e => e.ImporteVdmpCalculado)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ImporteVDMP_calculado");
            entity.Property(e => e.ImporteVdmpEnfactura)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ImporteVDMP_enfactura");
            entity.Property(e => e.ImpoteGestionColectivo)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Impote_GestionColectivo");
            entity.Property(e => e.NumLineasColectivo).HasColumnName("Num_lineasColectivo");
            entity.Property(e => e.NumLineasOtm).HasColumnName("Num_lineasOTM");
            entity.Property(e => e.NumLineasSocios).HasColumnName("Num_lineasSocios");
            entity.Property(e => e.SumaPuntosRepartidos).HasColumnName("Suma_PuntosRepartidos");
        });

        modelBuilder.Entity<SutRegistroAccesosTablas>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("SUT_RegistroAccesosTablas");

            entity.Property(e => e.Idregistro).HasColumnName("IDRegistro");
            entity.Property(e => e.FechaHora).HasColumnType("datetime");
            entity.Property(e => e.Idadmin).HasColumnName("IDAdmin");
            entity.Property(e => e.Registro).HasMaxLength(100);
            entity.Property(e => e.Tabla).HasMaxLength(25);
            entity.Property(e => e.TipoAcceso).HasMaxLength(2);
        });

        modelBuilder.Entity<SutRegistrovbp>(entity =>
        {
            entity.HasKey(e => e.IdregistroVbp);

            entity.ToTable("SUT_REGISTROVBP");

            entity.Property(e => e.IdregistroVbp).HasColumnName("idregistroVbp");
            entity.Property(e => e.Aplicacion)
                .HasMaxLength(50)
                .HasColumnName("aplicacion");
            entity.Property(e => e.DescripcionError)
                .HasMaxLength(1000)
                .HasColumnName("descripcion_error");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .HasColumnName("estado");
            entity.Property(e => e.EstadoAnterior)
                .HasMaxLength(10)
                .HasColumnName("estado_anterior");
            entity.Property(e => e.FechaEntrada)
                .HasColumnType("datetime")
                .HasColumnName("fecha_entrada");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fecha_estado");
            entity.Property(e => e.FechaLanzamientoSuscrip)
                .HasColumnType("datetime")
                .HasColumnName("fecha_lanzamiento_suscrip");
            entity.Property(e => e.FechaProcesoDesuscrip)
                .HasColumnType("datetime")
                .HasColumnName("fecha_proceso_desuscrip");
            entity.Property(e => e.FechaProcesoSuscrip)
                .HasColumnType("datetime")
                .HasColumnName("fecha_proceso_suscrip");
            entity.Property(e => e.FechaUltimaRenovacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ultima_renovacion");
            entity.Property(e => e.Idcolectivo).HasColumnName("idcolectivo");
            entity.Property(e => e.Idlinea).HasColumnName("idlinea");
            entity.Property(e => e.Idusuario).HasColumnName("idusuario");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.Movil)
                .HasMaxLength(9)
                .HasColumnName("movil");
            entity.Property(e => e.MovilUserId)
                .HasMaxLength(9)
                .HasColumnName("movil_userId");
            entity.Property(e => e.ProductId)
                .HasMaxLength(20)
                .HasColumnName("product_id");
            entity.Property(e => e.ServiceId)
                .HasMaxLength(20)
                .HasColumnName("service_id");
            entity.Property(e => e.ServiceList)
                .HasMaxLength(1024)
                .HasColumnName("serviceList");
            entity.Property(e => e.UltimoCodigoRespuesta)
                .HasMaxLength(10)
                .HasColumnName("ultimo_codigo_respuesta");
            entity.Property(e => e.UltimoCodigoRetornado)
                .HasMaxLength(10)
                .HasColumnName("ultimo_codigo_retornado");
            entity.Property(e => e.UsrEmail)
                .HasMaxLength(20)
                .HasColumnName("usr_email");
        });

        modelBuilder.Entity<SutReparaTerminales>(entity =>
        {
            entity.HasKey(e => e.IdSolicitud);

            entity.ToTable("SUT_REPARA_TERMINALES");

            entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");
            entity.Property(e => e.AdeudoCoopEura)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADEUDO_COOP_EURA");
            entity.Property(e => e.AvisadoSms).HasColumnName("avisadoSMS");
            entity.Property(e => e.CargadorBotiquin).HasMaxLength(50);
            entity.Property(e => e.CodPostalRecogida)
                .HasMaxLength(5)
                .HasColumnName("codPostalRecogida");
            entity.Property(e => e.CosteColectivoRenovePprecios)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CosteColectivoRenovePPrecios");
            entity.Property(e => e.CostePvprenovePprecios)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CostePVPRenovePPrecios");
            entity.Property(e => e.CosteReparacion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DescCompromiso)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("desc_compromiso");
            entity.Property(e => e.DescuentoUsuarioEura)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DESCUENTO_USUARIO_EURA");
            entity.Property(e => e.DireccionRecogida)
                .HasMaxLength(1000)
                .HasColumnName("direccionRecogida");
            entity.Property(e => e.EstadoSolicitud)
                .HasMaxLength(50)
                .HasColumnName("estado_solicitud");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FechaDesdeCompromiso)
                .HasColumnType("datetime")
                .HasColumnName("fechaDesde_compromiso");
            entity.Property(e => e.FechaEntregaNuevo)
                .HasColumnType("datetime")
                .HasColumnName("fecha_entrega_nuevo");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fecha_estado");
            entity.Property(e => e.FechaHastaCompromiso)
                .HasColumnType("datetime")
                .HasColumnName("fechaHasta_compromiso");
            entity.Property(e => e.FechaOrden)
                .HasColumnType("datetime")
                .HasColumnName("fecha_orden");
            entity.Property(e => e.FechaRecepcionNuevo)
                .HasColumnType("datetime")
                .HasColumnName("fecha_recepcion_nuevo");
            entity.Property(e => e.FechaRecogidaViejo)
                .HasColumnType("datetime")
                .HasColumnName("fecha_recogida_viejo");
            entity.Property(e => e.FechaTerminalIrreparable).HasColumnType("datetime");
            entity.Property(e => e.FechaUltimoAviso).HasColumnType("datetime");
            entity.Property(e => e.FidelizacionEura).HasColumnName("FIDELIZACION_EURA");
            entity.Property(e => e.Fumr)
                .HasMaxLength(25)
                .HasColumnName("FUMR");
            entity.Property(e => e.HistoricoCambiosEstado)
                .HasMaxLength(4000)
                .HasColumnName("historicoCambiosEstado");
            entity.Property(e => e.HistoricoComentarios)
                .HasMaxLength(4000)
                .HasColumnName("historicoComentarios");
            entity.Property(e => e.IdColectivo).HasColumnName("id_colectivo");
            entity.Property(e => e.IdCompromiso).HasColumnName("id_compromiso");
            entity.Property(e => e.IdLinea).HasColumnName("id_linea");
            entity.Property(e => e.IdOperador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_operador");
            entity.Property(e => e.IdPlanPreciosPedidoRenove).HasColumnName("idPlanPreciosPedidoRenove");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdfinanTf).HasColumnName("idfinan_TF");
            entity.Property(e => e.ImporteTotalCompromiso)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("importeTotal_compromiso");
            entity.Property(e => e.InfoAdicional).HasMaxLength(500);
            entity.Property(e => e.LugarRecogida).HasMaxLength(50);
            entity.Property(e => e.MedioOrden)
                .HasMaxLength(50)
                .HasColumnName("medio_orden");
            entity.Property(e => e.MotivoIncidencia).HasMaxLength(50);
            entity.Property(e => e.NombreCompromiso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_compromiso");
            entity.Property(e => e.ObservacionesEntrega)
                .HasMaxLength(255)
                .HasColumnName("observaciones_entrega");
            entity.Property(e => e.ObservacionesRecepcion)
                .HasMaxLength(255)
                .HasColumnName("observaciones_recepcion");
            entity.Property(e => e.ObservacionesRecogida)
                .HasMaxLength(255)
                .HasColumnName("observaciones_recogida");
            entity.Property(e => e.OrdenOperador)
                .HasMaxLength(50)
                .HasColumnName("orden_operador");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Permanencia).HasColumnName("permanencia");
            entity.Property(e => e.PermanenciaEura).HasColumnName("PERMANENCIA_EURA");
            entity.Property(e => e.PoblacionRecogida)
                .HasMaxLength(50)
                .HasColumnName("poblacionRecogida");
            entity.Property(e => e.ProvinciaRecogida)
                .HasMaxLength(50)
                .HasColumnName("provinciaRecogida");
            entity.Property(e => e.RenovePpreciosPublicado).HasColumnName("RenovePPreciosPublicado");
            entity.Property(e => e.TarifaDatos)
                .HasMaxLength(50)
                .HasColumnName("tarifaDatos");
            entity.Property(e => e.TelefonoContacto)
                .HasMaxLength(50)
                .HasColumnName("telefono_contacto");
            entity.Property(e => e.TerminalBotiquin).HasMaxLength(50);
            entity.Property(e => e.TerminalFinanciado).HasColumnName("terminalFinanciado");
            entity.Property(e => e.TipoOperadorCreador)
                .HasMaxLength(50)
                .HasColumnName("tipoOperadorCreador");
            entity.Property(e => e.TipoSolicitud)
                .HasMaxLength(50)
                .HasColumnName("tipo_solicitud");
            entity.Property(e => e.TnBateria)
                .HasMaxLength(50)
                .HasColumnName("tn_bateria");
            entity.Property(e => e.TnCargador)
                .HasMaxLength(50)
                .HasColumnName("tn_cargador");
            entity.Property(e => e.TnCosteEuros)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("tn_coste_euros");
            entity.Property(e => e.TnCosteEvfTotal)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("tn_costeEVF_total");
            entity.Property(e => e.TnCostePuntos)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("tn_coste_puntos");
            entity.Property(e => e.TnCosteSubvencionPuntos)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("tn_coste_subvencion_puntos");
            entity.Property(e => e.TnDesperfectos)
                .HasMaxLength(255)
                .HasColumnName("tn_desperfectos");
            entity.Property(e => e.TnImei)
                .HasMaxLength(20)
                .HasColumnName("tn_imei");
            entity.Property(e => e.TnImporteMarginado)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("tn_importe_marginado");
            entity.Property(e => e.TnMarca)
                .HasMaxLength(50)
                .HasColumnName("tn_marca");
            entity.Property(e => e.TnModelo)
                .HasMaxLength(50)
                .HasColumnName("tn_modelo");
            entity.Property(e => e.TnPublicado).HasColumnName("tn_publicado");
            entity.Property(e => e.TnTerminal)
                .HasMaxLength(50)
                .HasColumnName("tn_Terminal");
            entity.Property(e => e.TvBateria)
                .HasMaxLength(50)
                .HasColumnName("tv_bateria");
            entity.Property(e => e.TvCargador)
                .HasMaxLength(50)
                .HasColumnName("tv_cargador");
            entity.Property(e => e.TvDesperfectos)
                .HasMaxLength(255)
                .HasColumnName("tv_desperfectos");
            entity.Property(e => e.TvImei)
                .HasMaxLength(20)
                .HasColumnName("tv_imei");
            entity.Property(e => e.TvMarca)
                .HasMaxLength(50)
                .HasColumnName("tv_marca");
            entity.Property(e => e.TvModelo)
                .HasMaxLength(50)
                .HasColumnName("tv_modelo");
            entity.Property(e => e.TvTerminal)
                .HasMaxLength(50)
                .HasColumnName("tv_Terminal");
        });

        modelBuilder.Entity<SutResultadosSimulacion>(entity =>
        {
            entity.HasKey(e => e.Idauto);

            entity.ToTable("SUT_RESULTADOS_SIMULACION");

            entity.HasIndex(e => new { e.Idproceso, e.Codatrb, e.Emisor }, "IX_SUT_RESULTADOS_SIMULACION_procesos").HasFillFactor(80);

            entity.Property(e => e.Idauto).HasColumnName("IDAUTO");
            entity.Property(e => e.Codatrb)
                .HasMaxLength(20)
                .HasColumnName("CODATRB");
            entity.Property(e => e.Codfacturacion)
                .HasMaxLength(25)
                .HasColumnName("CODFACTURACION");
            entity.Property(e => e.Emisor)
                .HasMaxLength(5)
                .HasColumnName("EMISOR");
            entity.Property(e => e.Fechadesde)
                .HasMaxLength(10)
                .HasColumnName("FECHADESDE");
            entity.Property(e => e.Fechahasta)
                .HasMaxLength(10)
                .HasColumnName("FECHAHASTA");
            entity.Property(e => e.Idcolectivo).HasColumnName("IDCOLECTIVO");
            entity.Property(e => e.Idlinea).HasColumnName("IDLINEA");
            entity.Property(e => e.Idproceso).HasColumnName("IDPROCESO");
            entity.Property(e => e.Idusuario).HasColumnName("IDUSUARIO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.Numtelefono)
                .HasMaxLength(50)
                .HasColumnName("NUMTELEFONO");
            entity.Property(e => e.Texto)
                .HasMaxLength(200)
                .HasColumnName("TEXTO");
        });

        modelBuilder.Entity<SutResumenConcFactura>(entity =>
        {
            entity.HasKey(e => e.IdConcepto);

            entity.ToTable("SUT_RESUMEN_CONC_FACTURA");

            entity.HasIndex(e => e.IdFactura, "IX_SUT_RESUMEN_CONC_FACTURA_procesos").HasFillFactor(80);

            entity.Property(e => e.CodConcepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImporteNeto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NombreConcepto).HasMaxLength(150);
            entity.Property(e => e.TipoConcepto)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.SutResumenConcFactura)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUT_RESUMEN_CONC_FACTURA_SUT_FACTURAS");
        });

        modelBuilder.Entity<SutResumenConcFacturaPfm>(entity =>
        {
            entity.HasKey(e => e.IdConcepto);

            entity.ToTable("SUT_RESUMEN_CONC_FACTURA_PFM");

            entity.Property(e => e.CodConcepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImporteNeto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NombreConcepto).HasMaxLength(150);
            entity.Property(e => e.TipoConcepto)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.SutResumenConcFacturaPfm)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUT_RESUMEN_CONC_FACTURA_PFM_SUT_FACTURAS_PFM");
        });

        modelBuilder.Entity<SutServicios>(entity =>
        {
            entity.HasKey(e => e.IdServicio);

            entity.ToTable("SUT_SERVICIOS");

            entity.HasIndex(e => new { e.IdLinea, e.Tipo, e.FechaAlta, e.FechaBaja }, "IX_SUT_SERVICIOS_procesos").HasFillFactor(80);

            entity.Property(e => e.AtribOpcAlta)
                .HasMaxLength(100)
                .HasColumnName("ATRIB_OPC_ALTA");
            entity.Property(e => e.CodPenalizacion)
                .HasMaxLength(100)
                .HasColumnName("COD_PENALIZACION");
            entity.Property(e => e.Comentarios).HasMaxLength(500);
            entity.Property(e => e.CosteAlta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("COSTE_ALTA");
            entity.Property(e => e.CosteColectivo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("COSTE_COLECTIVO");
            entity.Property(e => e.CosteMensual)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Coste_Mensual");
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.IdAdminCreador).HasColumnName("idAdminCreador");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.ImportePermanencia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IMPORTE_PERMANENCIA");
            entity.Property(e => e.MesesPermanencia).HasColumnName("MESES_PERMANENCIA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Parametros)
                .HasMaxLength(500)
                .HasColumnName("PARAMETROS");
            entity.Property(e => e.PerfilUsuario)
                .HasMaxLength(1)
                .HasDefaultValue("S");
            entity.Property(e => e.ServIncomp)
                .HasMaxLength(100)
                .HasColumnName("SERV_INCOMP");
            entity.Property(e => e.Tipo).HasMaxLength(25);
            entity.Property(e => e.TipoActivacion).HasColumnName("TIPO_ACTIVACION");
            entity.Property(e => e.TipoPermanencia)
                .HasMaxLength(1)
                .HasColumnName("TIPO_PERMANENCIA");

            entity.HasOne(d => d.IdLineaNavigation).WithMany(p => p.SutServicios)
                .HasForeignKey(d => d.IdLinea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUT_SERVICIOS_SUT_LINEAS");
        });

        modelBuilder.Entity<SutSesionesUsuario>(entity =>
        {
            entity.ToTable("SUT_SESIONES_USUARIO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaUltimaActividad).HasColumnType("datetime");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idusuario).HasColumnName("IDUsuario");
            entity.Property(e => e.IpConexion).HasMaxLength(39);
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UltimaPaginaVisitada).HasMaxLength(500);
        });

        modelBuilder.Entity<SutSims>(entity =>
        {
            entity.HasKey(e => e.IdSim);

            entity.ToTable("SUT_SIMS");

            entity.Property(e => e.ESim).HasColumnName("eSIM");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaActivacion).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.IdAdminCreador).HasColumnName("idAdminCreador");
            entity.Property(e => e.InfoAdicional).IsUnicode(false);
            entity.Property(e => e.MultiSim).HasColumnName("MultiSIM");
            entity.Property(e => e.NumSim)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PinOriginal)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Puk)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.HasOne(d => d.IdLineaNavigation).WithMany(p => p.SutSims)
                .HasForeignKey(d => d.IdLinea)
                .HasConstraintName("FK_SUT_SIMS_SUT_LINEAS");
        });

        modelBuilder.Entity<SutTareasApiVodafone>(entity =>
        {
            entity.HasKey(e => e.Idtarea);

            entity.ToTable("SUT_TareasApiVodafone");

            entity.Property(e => e.Idtarea).HasColumnName("IDTarea");
            entity.Property(e => e.Cif)
                .HasMaxLength(15)
                .HasColumnName("CIF");
            entity.Property(e => e.CifReal)
                .HasMaxLength(15)
                .HasColumnName("CIF_real");
            entity.Property(e => e.CodError).HasMaxLength(10);
            entity.Property(e => e.CodRestriccion).HasMaxLength(50);
            entity.Property(e => e.CuentaInstalacion).HasMaxLength(25);
            entity.Property(e => e.EmailNotificacionAdmin).HasMaxLength(250);
            entity.Property(e => e.EstadoRestriccion).HasMaxLength(15);
            entity.Property(e => e.EstadoTarea).HasMaxLength(15);
            entity.Property(e => e.FechaEnvioSolicitada).HasColumnType("datetime");
            entity.Property(e => e.FechaEstadoTarea).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistroTarea).HasColumnType("datetime");
            entity.Property(e => e.IdadminCreador).HasColumnName("IDAdminCreador");
            entity.Property(e => e.Idcolectivo).HasColumnName("IDColectivo");
            entity.Property(e => e.Idlinea).HasColumnName("IDLinea");
            entity.Property(e => e.Idticket).HasColumnName("IDTicket");
            entity.Property(e => e.MensajeError).HasMaxLength(4000);
            entity.Property(e => e.NumSim)
                .HasMaxLength(25)
                .HasColumnName("NumSIM");
            entity.Property(e => e.NumTelefono).HasMaxLength(50);
            entity.Property(e => e.TipoTarea).HasMaxLength(25);
        });

        modelBuilder.Entity<SutTempDetalleTelefonoFactura>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SUT_TEMP_DETALLE_TELEFONO_FACTURA");

            entity.Property(e => e.Destino)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DuracionLlamada).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Emisor)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("EMISOR");
            entity.Property(e => e.FechaDesde)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaHasta)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaHora)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImporteNeto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NumTelefRecep)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumTelefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarifa)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TipoDetalle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VolumenDatos).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<SutTempFacturas>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SUT_TEMP_FACTURAS");

            entity.Property(e => e.BaseImponible).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CodPostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ComentariosPagos).HasColumnName("comentariosPagos");
            entity.Property(e => e.Direccion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.EnlaceGenerado).HasMaxLength(2);
            entity.Property(e => e.EstadoNorma19).HasMaxLength(50);
            entity.Property(e => e.FactOtm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Fact_OTM");
            entity.Property(e => e.FechaCargo).HasColumnType("datetime");
            entity.Property(e => e.FechaFactura).HasColumnType("datetime");
            entity.Property(e => e.FechaFin)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FicheroNorma19).HasMaxLength(50);
            entity.Property(e => e.Generacion).HasMaxLength(1);
            entity.Property(e => e.IdAsociacionPerfilUsuario).HasColumnName("idAsociacionPerfilUsuario");
            entity.Property(e => e.IdClienteUsuario).HasColumnName("idClienteUsuario");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.IdProceso).HasColumnName("idProceso");
            entity.Property(e => e.ImporteBruto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImportePagos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importePagos");
            entity.Property(e => e.ImportePtePago)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importePtePago");
            entity.Property(e => e.ImportePuntos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Iva).HasColumnName("IVA");
            entity.Property(e => e.NombreBanco)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumCuenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumFactura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.Poblacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoFactura).HasMaxLength(50);
            entity.Property(e => e.TmImporteacuenta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_importeacuenta");
            entity.Property(e => e.TmImportecomision)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_importecomision");
            entity.Property(e => e.TmMesesPlazo).HasColumnName("tm_mesesPlazo");
            entity.Property(e => e.TmModoFin).HasColumnName("tm_modoFin");
            entity.Property(e => e.TmPreciocoste1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_preciocoste1");
            entity.Property(e => e.TmPreciocoste2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_preciocoste2");
            entity.Property(e => e.TmPrecioventa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tm_precioventa");
            entity.Property(e => e.TotalDescuentos).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalFactura).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<SutTerminales>(entity =>
        {
            entity.HasKey(e => e.IdTerminal);

            entity.ToTable("SUT_TERMINALES");

            entity.Property(e => e.Comentario).HasMaxLength(250);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fabricante)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCompra).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaTerminalIrreparable).HasColumnType("datetime");
            entity.Property(e => e.IdAdminCreador).HasColumnName("idAdminCreador");
            entity.Property(e => e.IdReparacion).HasColumnName("idReparacion");
            entity.Property(e => e.Imei)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ImporteCompra).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdLineaNavigation).WithMany(p => p.SutTerminales)
                .HasForeignKey(d => d.IdLinea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUT_TERMINALES_SUT_LINEAS");

            entity.HasOne(d => d.IdOperacionNavigation).WithMany(p => p.SutTerminales)
                .HasForeignKey(d => d.IdOperacion)
                .HasConstraintName("FK_SUT_TERMINALES_SUT_PUNTOS");
        });

        modelBuilder.Entity<SutTiposPeticiones>(entity =>
        {
            entity.HasKey(e => e.IdTipoPeticion);

            entity.ToTable("SUT_TIPOS_PETICIONES");

            entity.Property(e => e.AsignacionPerfil)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.ReenvioPerfil)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SutTokensEmails>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("SUT_TOKENS_EMAILS");

            entity.Property(e => e.Idregistro).HasColumnName("IDRegistro");
            entity.Property(e => e.DatosNavegadorConfirmacion)
                .HasMaxLength(300)
                .HasColumnName("DatosNavegador_Confirmacion");
            entity.Property(e => e.Estado).HasMaxLength(25);
            entity.Property(e => e.FechaHoraConfirmacion)
                .HasColumnType("datetime")
                .HasColumnName("FechaHora_Confirmacion");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Idadministrador).HasColumnName("IDAdministrador");
            entity.Property(e => e.Idcolectivo).HasColumnName("IDColectivo");
            entity.Property(e => e.Idusuario).HasColumnName("IDUsuario");
            entity.Property(e => e.IpConfirmacion)
                .HasMaxLength(15)
                .HasColumnName("IP_Confirmacion");
            entity.Property(e => e.Nifusuario)
                .HasMaxLength(9)
                .HasColumnName("NIFUsuario");
            entity.Property(e => e.Token).HasMaxLength(100);
        });

        modelBuilder.Entity<SutUsuarios>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.ToTable("SUT_USUARIOS");

            entity.HasIndex(e => e.NumCuenta, "IX_SUT_USUARIOS_procesos").HasFillFactor(80);

            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CuentaContable)
                .HasMaxLength(50)
                .HasColumnName("Cuenta_contable");
            entity.Property(e => e.DatosNavegadorAceptacionRgpd)
                .HasMaxLength(300)
                .HasColumnName("DatosNavegadorAceptacionRGPD");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAceptacionRgpd)
                .HasColumnType("datetime")
                .HasColumnName("FechaAceptacionRGPD");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaModif).HasColumnType("datetime");
            entity.Property(e => e.FechaNr)
                .HasColumnType("datetime")
                .HasColumnName("FechaNR");
            entity.Property(e => e.FechaOrdenDomiciliacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_orden_domiciliacion");
            entity.Property(e => e.FechaUltimaConexion).HasColumnType("datetime");
            entity.Property(e => e.Franquicia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FranquiciaMax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Fumr)
                .HasMaxLength(25)
                .HasColumnName("FUMR");
            entity.Property(e => e.IduVinculado).HasColumnName("IDU_VINCULADO");
            entity.Property(e => e.InfoAdicional)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.IpaceptacionRgpd)
                .HasMaxLength(15)
                .HasColumnName("IPAceptacionRGPD");
            entity.Property(e => e.Nif)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NiftitularBanco)
                .HasMaxLength(15)
                .HasColumnName("NIFTitularBanco");
            entity.Property(e => e.NivelRiesgo).HasMaxLength(4);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreBanco)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumCuenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumMovil)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumSocio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PerfilUsuario).HasMaxLength(1);
            entity.Property(e => e.RefOrdenDomiciliacion)
                .HasMaxLength(35)
                .HasColumnName("ref_orden_domiciliacion");
            entity.Property(e => e.SaldoPuntos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TitularBanco).HasMaxLength(100);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.SutUsuarios)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK_SUT_USUARIOS_Empresas");
        });

        modelBuilder.Entity<SutUsuariosTokens>(entity =>
        {
            entity.HasKey(e => new { e.Idusuario, e.Token });

            entity.ToTable("SUT_USUARIOS_TOKENS");

            entity.Property(e => e.Idusuario).HasColumnName("IDUsuario");
            entity.Property(e => e.Token).HasMaxLength(250);
        });

        modelBuilder.Entity<SutVdmEdicionesProductos>(entity =>
        {
            entity.HasKey(e => e.IdEdicion).HasName("PK_SUT_EDICIONES_PRODUCTOS_VDM");

            entity.ToTable("SUT_VDM_EDICIONES_PRODUCTOS");

            entity.Property(e => e.IdEdicion).HasColumnName("idEdicion");
            entity.Property(e => e.Aplicacion)
                .HasMaxLength(10)
                .HasColumnName("aplicacion");
            entity.Property(e => e.ClaveConsumidorProducto)
                .HasMaxLength(50)
                .HasColumnName("claveConsumidorProducto");
            entity.Property(e => e.CodEdicion)
                .HasMaxLength(50)
                .HasColumnName("codEdicion");
            entity.Property(e => e.DescProducto)
                .HasMaxLength(100)
                .HasColumnName("descProducto");
            entity.Property(e => e.EstadoEdicion)
                .HasMaxLength(10)
                .HasColumnName("estadoEdicion");
            entity.Property(e => e.FechaEstadoEdicion)
                .HasColumnType("datetime")
                .HasColumnName("fechaEstadoEdicion");
            entity.Property(e => e.ImporteUnidad)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importeUnidad");
            entity.Property(e => e.NombreEdicion)
                .HasMaxLength(50)
                .HasColumnName("nombreEdicion");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(50)
                .HasColumnName("nombreProducto");
            entity.Property(e => e.SecretoConsumidorProducto)
                .HasMaxLength(25)
                .HasColumnName("secretoConsumidorProducto");
            entity.Property(e => e.TipoUnidad)
                .HasMaxLength(10)
                .HasColumnName("tipoUnidad");
        });

        modelBuilder.Entity<SutVdmHistorico>(entity =>
        {
            entity.HasKey(e => e.IdRegistro);

            entity.ToTable("SUT_VDM_HISTORICO");

            entity.Property(e => e.IdRegistro).HasColumnName("idRegistro");
            entity.Property(e => e.Aplicacion)
                .HasMaxLength(10)
                .HasColumnName("aplicacion");
            entity.Property(e => e.Comentarios).HasMaxLength(100);
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .HasColumnName("estado");
            entity.Property(e => e.FechaEntrada)
                .HasColumnType("datetime")
                .HasColumnName("fechaEntrada");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fechaEstado");
            entity.Property(e => e.FechaLanzamiento)
                .HasColumnType("datetime")
                .HasColumnName("fechaLanzamiento");
            entity.Property(e => e.FechaPasoVdm)
                .HasColumnType("datetime")
                .HasColumnName("fechaPasoVDM");
            entity.Property(e => e.FechaUltimaSolicitud)
                .HasColumnType("datetime")
                .HasColumnName("fechaUltimaSolicitud");
            entity.Property(e => e.IdClienteVdm)
                .HasMaxLength(100)
                .HasColumnName("idClienteVDM");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.IdEdicion).HasColumnName("idEdicion");
            entity.Property(e => e.IdLinea).HasColumnName("idLinea");
            entity.Property(e => e.IdSolicitudLastVdm).HasColumnName("idSolicitud_LastVDM");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.NumMovil)
                .HasMaxLength(15)
                .HasColumnName("numMovil");
        });

        modelBuilder.Entity<SutVdmSolicitudes>(entity =>
        {
            entity.HasKey(e => e.IdSolicitud);

            entity.ToTable("SUT_VDM_SOLICITUDES");

            entity.Property(e => e.IdSolicitud).HasColumnName("idSolicitud");
            entity.Property(e => e.CodEdicion)
                .HasMaxLength(50)
                .HasColumnName("codEdicion");
            entity.Property(e => e.CodigoRespuesta)
                .HasMaxLength(15)
                .HasColumnName("codigoRespuesta");
            entity.Property(e => e.DescRespuesta)
                .HasMaxLength(255)
                .HasColumnName("descRespuesta");
            entity.Property(e => e.EstadoSolicitud)
                .HasMaxLength(10)
                .HasColumnName("estadoSolicitud");
            entity.Property(e => e.FechaProceso)
                .HasColumnType("datetime")
                .HasColumnName("fechaProceso");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdCuenta)
                .HasMaxLength(100)
                .HasColumnName("idCuenta");
            entity.Property(e => e.ImporteTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importeTotal");
            entity.Property(e => e.TotalUnidades).HasColumnName("totalUnidades");
        });

        modelBuilder.Entity<SutVdmSuscripcionesUsuarios>(entity =>
        {
            entity.HasKey(e => e.IdSuscripcion);

            entity.ToTable("SUT_VDM_SUSCRIPCIONES_USUARIOS");

            entity.Property(e => e.IdSuscripcion).HasColumnName("idSuscripcion");
            entity.Property(e => e.CifAutorizado)
                .HasMaxLength(15)
                .HasColumnName("cifAutorizado");
            entity.Property(e => e.DatosCreador)
                .HasMaxLength(2000)
                .HasColumnName("datosCreador");
            entity.Property(e => e.EmailAutorizado)
                .HasMaxLength(100)
                .HasColumnName("emailAutorizado");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .HasColumnName("estado");
            entity.Property(e => e.FechaEstado)
                .HasColumnType("datetime")
                .HasColumnName("fechaEstado");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdClienteVdm)
                .HasMaxLength(100)
                .HasColumnName("idClienteVDM");
            entity.Property(e => e.IdCuenta)
                .HasMaxLength(100)
                .HasColumnName("idCuenta");
            entity.Property(e => e.IdEdicion).HasColumnName("idEdicion");
            entity.Property(e => e.MovilAutorizado)
                .HasMaxLength(15)
                .HasColumnName("movilAutorizado");
            entity.Property(e => e.NombreAutorizado)
                .HasMaxLength(100)
                .HasColumnName("nombreAutorizado");
            entity.Property(e => e.NombreEmpresaAutorizado)
                .HasMaxLength(100)
                .HasColumnName("nombreEmpresaAutorizado");
            entity.Property(e => e.RazonSocialAutorizado)
                .HasMaxLength(100)
                .HasColumnName("razonSocialAutorizado");
            entity.Property(e => e.TotalUnidadesActivas).HasColumnName("totalUnidadesActivas");
        });

        modelBuilder.Entity<SutVdmUsuarios>(entity =>
        {
            entity.ToTable("SUT_VDM_USUARIOS");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aplicacion)
                .HasMaxLength(25)
                .HasColumnName("aplicacion");
            entity.Property(e => e.Cif)
                .HasMaxLength(15)
                .HasColumnName("cif");
            entity.Property(e => e.IdClienteInterno).HasColumnName("idClienteInterno");
            entity.Property(e => e.IdClienteVdm)
                .HasMaxLength(100)
                .HasColumnName("idClienteVDM");
            entity.Property(e => e.IdCuenta)
                .HasMaxLength(100)
                .HasColumnName("idCuenta");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(100)
                .HasColumnName("nombreCliente");
        });

        modelBuilder.Entity<SutVerifSocios>(entity =>
        {
            entity.ToTable("SUT_VERIF_SOCIOS");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdColectivo).HasColumnName("idColectivo");
            entity.Property(e => e.IdSocio).HasColumnName("idSocio");
        });

        modelBuilder.Entity<Tarifas>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IdConcepto).HasColumnName("idConcepto");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.IdOperadora).HasColumnName("idOperadora");
        });

        modelBuilder.Entity<TiposDestino>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IdConcepto).HasColumnName("idConcepto");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.IdOperadora).HasColumnName("idOperadora");
        });

        modelBuilder.Entity<TiposLlamada>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IdConcepto).HasColumnName("idConcepto");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.IdOperadora).HasColumnName("idOperadora");
        });

        modelBuilder.Entity<TiposServicio>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IdConcepto).HasColumnName("idConcepto");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.IdOperadora).HasColumnName("idOperadora");
        });

        modelBuilder.Entity<TiposTrafico>(entity =>
        {
            entity.HasKey(e => new { e.Codigo, e.IdOperadora, e.IdEmpresa });

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.GrupoTrafico)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<TmpLineasColectivizar>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TMP_LINEAS_COLECTIVIZAR");

            entity.Property(e => e.Idregistro).HasColumnName("IDREGISTRO");
            entity.Property(e => e.Cant).HasColumnName("CANT");
            entity.Property(e => e.Idcliente).HasColumnName("IDCLIENTE");
            entity.Property(e => e.NumLineas).HasColumnName("NUM_LINEAS");
            entity.Property(e => e.Telef)
                .HasMaxLength(25)
                .HasColumnName("TELEF");
        });

        modelBuilder.Entity<TmpSutCuotasServiciosVf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_SUT_CuotasServiciosVF");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(10)
                .HasColumnName("ciclo");
            entity.Property(e => e.CodServicioSunit)
                .HasMaxLength(100)
                .HasColumnName("cod_servicio_sunit");
            entity.Property(e => e.CodtarifaOperador)
                .HasMaxLength(25)
                .HasColumnName("codtarifa_operador");
            entity.Property(e => e.CuentaVf)
                .HasMaxLength(15)
                .HasColumnName("cuenta_vf");
            entity.Property(e => e.Dias).HasColumnName("dias");
            entity.Property(e => e.DiasCiclo).HasColumnName("diasCiclo");
            entity.Property(e => e.EstadoLinea)
                .HasMaxLength(50)
                .HasColumnName("estado_linea");
            entity.Property(e => e.FaltaLinea)
                .HasColumnType("datetime")
                .HasColumnName("falta_linea");
            entity.Property(e => e.FaltaServicio)
                .HasColumnType("datetime")
                .HasColumnName("falta_servicio");
            entity.Property(e => e.FbajaLinea)
                .HasColumnType("datetime")
                .HasColumnName("fbaja_linea");
            entity.Property(e => e.FbajaServicio)
                .HasColumnType("datetime")
                .HasColumnName("fbaja_servicio");
            entity.Property(e => e.FechaDesde)
                .HasColumnType("datetime")
                .HasColumnName("fecha_desde");
            entity.Property(e => e.FechaHasta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hasta");
            entity.Property(e => e.Idc).HasColumnName("idc");
            entity.Property(e => e.Idl).HasColumnName("idl");
            entity.Property(e => e.Idu).HasColumnName("idu");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("importe");
            entity.Property(e => e.Linea)
                .HasMaxLength(25)
                .HasColumnName("linea");
            entity.Property(e => e.LiteralServicioSunit)
                .HasMaxLength(250)
                .HasColumnName("literal_servicio_sunit");
            entity.Property(e => e.Literalasociado)
                .HasMaxLength(100)
                .HasColumnName("literalasociado");
            entity.Property(e => e.Precioneto)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("precioneto");
            entity.Property(e => e.Tipolinea)
                .HasMaxLength(10)
                .HasColumnName("tipolinea");
        });

        modelBuilder.Entity<TmpTrgVdfDetalleCuotas>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TMP_TRG_VDF_DetalleCuotas");

            entity.Property(e => e.Idregistro)
                .ValueGeneratedNever()
                .HasColumnName("IDREGISTRO");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.DescripCuota)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DESCRIP_CUOTA");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.FechaFin)
                .HasMaxLength(50)
                .HasColumnName("FECHA_FIN");
            entity.Property(e => e.FechaInicio)
                .HasMaxLength(50)
                .HasColumnName("FECHA_INICIO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.Packsg).HasColumnName("PACKSG");
            entity.Property(e => e.Telef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF");
            entity.Property(e => e.TelefOld)
                .HasMaxLength(50)
                .HasColumnName("TELEF_OLD");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
        });

        modelBuilder.Entity<TmpTrgVdfDetalleTelefono>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TMP_TRG_VDF_DetalleTelefono");

            entity.Property(e => e.Idregistro)
                .ValueGeneratedNever()
                .HasColumnName("IDREGISTRO");
            entity.Property(e => e.Canal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANAL");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Destino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESTINO");
            entity.Property(e => e.DuracSes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURAC_SES");
            entity.Property(e => e.Duracion)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DURACION");
            entity.Property(e => e.ExcedeLimiteDuracion).HasColumnName("EXCEDE_LIMITE_DURACION");
            entity.Property(e => e.ExtOrigen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXT_ORIGEN");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.FechaHora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA_HORA");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE_NETO");
            entity.Property(e => e.NoOrigen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NO_ORIGEN");
            entity.Property(e => e.NoRecep)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NO_RECEP");
            entity.Property(e => e.Packsg).HasColumnName("PACKSG");
            entity.Property(e => e.Pasos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASOS");
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TARIFA");
            entity.Property(e => e.TelefExt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF_EXT");
            entity.Property(e => e.TelefExtOld)
                .HasMaxLength(50)
                .HasColumnName("TELEF_EXT_OLD");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoFact)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_FACT");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
            entity.Property(e => e.Volumen)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VOLUMEN");
        });

        modelBuilder.Entity<TmpTrgVdfFacturas>(entity =>
        {
            entity.HasKey(e => e.FactNo);

            entity.ToTable("TMP_TRG_VDF_FACTURAS");

            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .HasColumnName("FACT_NO");
        });

        modelBuilder.Entity<TmpTrgVdfFinanciacion>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TMP_TRG_VDF_Financiacion");

            entity.Property(e => e.Idregistro)
                .ValueGeneratedNever()
                .HasColumnName("IDREGISTRO");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(8)
                .HasColumnName("CICLO");
            entity.Property(e => e.Conciliacion)
                .HasMaxLength(10)
                .HasColumnName("CONCILIACION");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.ImporteConciliacion)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE_CONCILIACION");
            entity.Property(e => e.Telef)
                .HasMaxLength(50)
                .HasColumnName("TELEF");
            entity.Property(e => e.TelefOld)
                .HasMaxLength(50)
                .HasColumnName("TELEF_OLD");
            entity.Property(e => e.TipoConcep)
                .HasMaxLength(100)
                .HasColumnName("TIPO_CONCEP");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(8)
                .HasColumnName("TIPOREG");
        });

        modelBuilder.Entity<TmpTrgVdfResumenTelefono>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TMP_TRG_VDF_ResumenTelefono");

            entity.Property(e => e.Idregistro)
                .ValueGeneratedNever()
                .HasColumnName("IDREGISTRO");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUENTA");
            entity.Property(e => e.Cuotas)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CUOTAS");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE_NETO");
            entity.Property(e => e.PPreciosDatos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P_PRECIOS_DATOS");
            entity.Property(e => e.PPreciosVoz)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P_PRECIOS_VOZ");
            entity.Property(e => e.Telef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF");
            entity.Property(e => e.TelefOld)
                .HasMaxLength(50)
                .HasColumnName("TELEF_OLD");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
        });

        modelBuilder.Entity<TmpVdfResumenFacturacionCompleta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TMP_VDF_ResumenFacturacionCompleta");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .HasColumnName("CICLO");
            entity.Property(e => e.Desconsumo)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DESCONSUMO");
            entity.Property(e => e.Descuota)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DESCUOTA");
            entity.Property(e => e.DirCodpostal)
                .HasMaxLength(5)
                .HasColumnName("DIR_CODPOSTAL");
            entity.Property(e => e.DirDireccion)
                .HasMaxLength(1000)
                .HasColumnName("DIR_DIRECCION");
            entity.Property(e => e.DirNombre)
                .HasMaxLength(50)
                .HasColumnName("DIR_NOMBRE");
            entity.Property(e => e.DirPoblacion)
                .HasMaxLength(50)
                .HasColumnName("DIR_POBLACION");
            entity.Property(e => e.DirProvincia)
                .HasMaxLength(50)
                .HasColumnName("DIR_PROVINCIA");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Extnumtelefono)
                .HasMaxLength(9)
                .HasColumnName("EXTNUMTELEFONO");
            entity.Property(e => e.Fechaalta)
                .HasColumnType("datetime")
                .HasColumnName("FECHAALTA");
            entity.Property(e => e.Fechabaja)
                .HasColumnType("datetime")
                .HasColumnName("FECHABAJA");
            entity.Property(e => e.Fechafin)
                .HasMaxLength(50)
                .HasColumnName("FECHAFIN");
            entity.Property(e => e.Fechainicio)
                .HasMaxLength(50)
                .HasColumnName("FECHAINICIO");
            entity.Property(e => e.Idempresa).HasColumnName("IDEMPRESA");
            entity.Property(e => e.Idlinea).HasColumnName("IDLINEA");
            entity.Property(e => e.Idusuariolin).HasColumnName("IDUSUARIOLIN");
            entity.Property(e => e.Impconsumo)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPCONSUMO");
            entity.Property(e => e.Impcuota)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPCUOTA");
            entity.Property(e => e.NifCif)
                .HasMaxLength(50)
                .HasColumnName("NIF_CIF");
            entity.Property(e => e.Telef)
                .HasMaxLength(50)
                .HasColumnName("TELEF");
            entity.Property(e => e.Telef3)
                .HasMaxLength(50)
                .HasColumnName("TELEF3");
            entity.Property(e => e.Tipolinea)
                .HasMaxLength(10)
                .HasColumnName("TIPOLINEA");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.UsuApellidos)
                .HasMaxLength(50)
                .HasColumnName("USU_APELLIDOS");
            entity.Property(e => e.UsuAsociacionperfilusuario).HasColumnName("USU_ASOCIACIONPERFILUSUARIO");
            entity.Property(e => e.UsuEstado)
                .HasMaxLength(50)
                .HasColumnName("USU_ESTADO");
            entity.Property(e => e.UsuExentofacturacion).HasColumnName("USU_EXENTOFACTURACION");
            entity.Property(e => e.UsuFechabaja)
                .HasColumnType("datetime")
                .HasColumnName("USU_FECHABAJA");
            entity.Property(e => e.UsuIdcliente).HasColumnName("USU_IDCLIENTE");
            entity.Property(e => e.UsuIdusuario).HasColumnName("USU_IDUSUARIO");
            entity.Property(e => e.UsuNif)
                .HasMaxLength(50)
                .HasColumnName("USU_NIF");
            entity.Property(e => e.UsuNombre)
                .HasMaxLength(50)
                .HasColumnName("USU_NOMBRE");
            entity.Property(e => e.UsuNombrebanco)
                .HasMaxLength(50)
                .HasColumnName("USU_NOMBREBANCO");
            entity.Property(e => e.UsuNumcuenta)
                .HasMaxLength(50)
                .HasColumnName("USU_NUMCUENTA");
            entity.Property(e => e.UsuPerfilusuario)
                .HasMaxLength(1)
                .HasColumnName("USU_PERFILUSUARIO");
            entity.Property(e => e.UsuRecibirfacturacorreopostal).HasColumnName("USU_RECIBIRFACTURACORREOPOSTAL");
            entity.Property(e => e.UsuRecibirfacturaemail).HasColumnName("USU_RECIBIRFACTURAEMAIL");
        });

        modelBuilder.Entity<TrgCabeceraMovil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_CABECERA_MOVIL");

            entity.Property(e => e.Anio).HasColumnName("ANIO");
            entity.Property(e => e.Cif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIF");
            entity.Property(e => e.Concepto).HasColumnName("CONCEPTO");
            entity.Property(e => e.Consumo)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("CONSUMO");
            entity.Property(e => e.Cuotamensual)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("CUOTAMENSUAL");
            entity.Property(e => e.Descuentos)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("DESCUENTOS");
            entity.Property(e => e.Dia).HasColumnName("DIA");
            entity.Property(e => e.Facturacion)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("FACTURACION");
            entity.Property(e => e.Fechafactura)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFACTURA");
            entity.Property(e => e.Impuestos)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("IMPUESTOS");
            entity.Property(e => e.Mes).HasColumnName("MES");
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFACTURA");
            entity.Property(e => e.Operador)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OPERADOR");
            entity.Property(e => e.Otrascuotas)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("OTRASCUOTAS");
            entity.Property(e => e.Otrosabonos)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("OTROSABONOS");
            entity.Property(e => e.Otroscargos)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("OTROSCARGOS");
            entity.Property(e => e.Tipoimpositivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOIMPOSITIVO");
            entity.Property(e => e.Totalconimpuestos)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("TOTALCONIMPUESTOS");
            entity.Property(e => e.Totalsinimpuestos)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("TOTALSINIMPUESTOS");
        });

        modelBuilder.Entity<TrgCabeceraVozDatos>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_CABECERA_VOZ_DATOS");

            entity.Property(e => e.Anio).HasColumnName("ANIO");
            entity.Property(e => e.Cif)
                .HasMaxLength(50)
                .HasColumnName("CIF");
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.Cuotamensual)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("CUOTAMENSUAL");
            entity.Property(e => e.Descuentos)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("DESCUENTOS");
            entity.Property(e => e.Dia).HasColumnName("DIA");
            entity.Property(e => e.Fechafactura)
                .HasColumnType("datetime")
                .HasColumnName("FECHAFACTURA");
            entity.Property(e => e.Impuestos)
                .HasMaxLength(50)
                .HasColumnName("IMPUESTOS");
            entity.Property(e => e.Mes).HasColumnName("MES");
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFACTURA");
            entity.Property(e => e.Nfacturainterna)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("NFACTURAINTERNA");
            entity.Property(e => e.Otrosabonos)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("OTROSABONOS");
            entity.Property(e => e.Tipoimpositivo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("TIPOIMPOSITIVO");
            entity.Property(e => e.Totalconimpuestos)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("TOTALCONIMPUESTOS");
            entity.Property(e => e.Totalsinimpuestos)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("TOTALSINIMPUESTOS");
        });

        modelBuilder.Entity<TrgCargas>(entity =>
        {
            entity.HasKey(e => e.IdCarga);

            entity.ToTable("TRG_CARGAS");

            entity.Property(e => e.EstadoCarga)
                .HasMaxLength(50)
                .HasColumnName("Estado_Carga");
            entity.Property(e => e.FechaCarga)
                .HasMaxLength(50)
                .HasColumnName("Fecha_Carga");
            entity.Property(e => e.Idempresa).HasColumnName("IDEmpresa");
            entity.Property(e => e.NombreFichero)
                .HasMaxLength(200)
                .HasColumnName("Nombre_Fichero");
            entity.Property(e => e.Operador).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgCargasFacturas>(entity =>
        {
            entity.HasKey(e => new { e.IdCarga, e.CodFactura });

            entity.ToTable("TRG_CARGAS_FACTURAS");

            entity.Property(e => e.IdCarga).HasColumnName("idCarga");
            entity.Property(e => e.CodFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codFactura");
            entity.Property(e => e.CargadoDw)
                .HasDefaultValue((byte)0)
                .HasColumnName("cargadoDW");
            entity.Property(e => e.FechaFactura).HasColumnType("smalldatetime");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
        });

        modelBuilder.Entity<TrgCompromisos>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_Compromisos");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Compromiso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Idempresa).HasColumnName("idempresa");
            entity.Property(e => e.Idoperadora).HasColumnName("idoperadora");
        });

        modelBuilder.Entity<TrgConsumoPorEmpleado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_ConsumoPorEmpleado");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cuotas).HasColumnName("cuotas");
            entity.Property(e => e.DescArea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DescCuotas).HasColumnName("descCuotas");
            entity.Property(e => e.DescProyecto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descuentos).HasColumnName("descuentos");
            entity.Property(e => e.IdEmpleado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idEmpleado");
            entity.Property(e => e.MarcAbrev)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.NTelfConex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nTelfConex");
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.NombreEmpleado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Ush)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USH");
            entity.Property(e => e.Varios).HasColumnName("varios");
        });

        modelBuilder.Entity<TrgDescuentosSinDescuadre>(entity =>
        {
            entity.HasKey(e => e.IdDescuentoSinDescuadre);

            entity.ToTable("TRG_DESCUENTOS_SIN_DESCUADRE");

            entity.Property(e => e.CodDescuento850)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpDescuento850)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpDescuentoAm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ImpDescuentoAM");
            entity.Property(e => e.NfacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFacturaInterna");
        });

        modelBuilder.Entity<TrgDetalleMovil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_DETALLE_MOVIL");

            entity.Property(e => e.Anio).HasColumnName("ANIO");
            entity.Property(e => e.Cantmedidaoriginada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANTMEDIDAORIGINADA");
            entity.Property(e => e.Cantmedidarecibida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANTMEDIDARECIBIDA");
            entity.Property(e => e.Cif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIF");
            entity.Property(e => e.Coddestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODDESTINO");
            entity.Property(e => e.Codllamada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODLLAMADA");
            entity.Property(e => e.Codproyecto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODPROYECTO");
            entity.Property(e => e.Codtrafico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODTRAFICO");
            entity.Property(e => e.Dia).HasColumnName("DIA");
            entity.Property(e => e.Duracion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURACION");
            entity.Property(e => e.Duraciondatos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURACIONDATOS");
            entity.Property(e => e.Fecha)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FECHA");
            entity.Property(e => e.Franja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FRANJA");
            entity.Property(e => e.Horainicio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("HORAINICIO");
            entity.Property(e => e.Importe)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.Importedatos)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("IMPORTEDATOS");
            entity.Property(e => e.Mes).HasColumnName("MES");
            entity.Property(e => e.Nextension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NEXTENSION");
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFACTURA");
            entity.Property(e => e.Nllamado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLLAMADO");
            entity.Property(e => e.Ntelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NTELEFONO");
            entity.Property(e => e.Operadordestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPERADORDESTINO");
            entity.Property(e => e.Operadororigen).HasColumnName("OPERADORORIGEN");
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TARIFA");
            entity.Property(e => e.Tipodestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPODESTINO");
            entity.Property(e => e.Tipollamada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOLLAMADA");
            entity.Property(e => e.Tipotrafico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOTRAFICO");
            entity.Property(e => e.Unidadmedida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIDADMEDIDA");
        });

        modelBuilder.Entity<TrgDetalleVoz>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_DETALLE_VOZ");

            entity.Property(e => e.AmbitoLlamada)
                .HasMaxLength(50)
                .HasColumnName("AmbitoLLamada");
            entity.Property(e => e.Anio).HasColumnName("ANIO");
            entity.Property(e => e.Cif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIF");
            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPer).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.Codproyecto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODPROYECTO");
            entity.Property(e => e.Destino).HasMaxLength(50);
            entity.Property(e => e.Dia).HasColumnName("DIA");
            entity.Property(e => e.Duracion).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Hora).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.ImporteEstandar).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.ImporteValor).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.Locuciones).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.Mes).HasColumnName("MES");
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nfacturainterna)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("NFACTURAINTERNA");
            entity.Property(e => e.Nrecibo)
                .HasMaxLength(50)
                .HasColumnName("NRecibo");
            entity.Property(e => e.NtelPer)
                .HasMaxLength(50)
                .HasColumnName("NTelPer");
            entity.Property(e => e.NumeroLlamado)
                .HasMaxLength(50)
                .HasColumnName("NumeroLLamado");
            entity.Property(e => e.OperadorProveedor).HasMaxLength(50);
            entity.Property(e => e.Origen).HasMaxLength(50);
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.Servicio).HasMaxLength(50);
            entity.Property(e => e.SubTipoTrafico).HasMaxLength(50);
            entity.Property(e => e.Tarifa).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
            entity.Property(e => e.TipoVariable).HasMaxLength(50);
            entity.Property(e => e.Unidades).HasColumnType("numeric(12, 0)");
            entity.Property(e => e.UnidadesVolumen).HasColumnType("numeric(12, 0)");
        });

        modelBuilder.Entity<TrgEmpresas>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_Empresas");

            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(50)
                .HasColumnName("codEmpresa");
            entity.Property(e => e.CodPostal).HasMaxLength(50);
            entity.Property(e => e.Domicilio).HasMaxLength(50);
            entity.Property(e => e.Localidad).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(65);
        });

        modelBuilder.Entity<TrgErroresFacturacion977>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_ERRORES_FACTURACION_977");

            entity.Property(e => e.Abonado)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodAgrupacionDetalle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodDesApli)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodDesPeriodo1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodDesPeriodo2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodDesPers)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodMulticonexion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodPaquete)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProdConcepFact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodProdPers)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoConcepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoRegistro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FInicio");
            entity.Property(e => e.ImporteAm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ImporteAM");
            entity.Property(e => e.ImporteDescuento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteDistancia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteEstandar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteTotal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteUnitario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Longitud)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nunidades)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUnidades");
            entity.Property(e => e.NunidadesPeriodo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUnidadesPeriodo1");
            entity.Property(e => e.NunidadesPeriodo2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUnidadesPeriodo2");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.RefAgrupacionFacturable)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoImpositivo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoServicio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoValoracion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrgErroresFacturacionMovil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_ERRORES_FACTURACION_MOVIL");

            entity.Property(e => e.Abonado)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ABONADO");
            entity.Property(e => e.Codcuota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODCUOTA");
            entity.Property(e => e.Descuota)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DESCUOTA");
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FFIN");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FINICIO");
            entity.Property(e => e.Importe)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("IMPORTE");
            entity.Property(e => e.ImporteAm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE_AM");
            entity.Property(e => e.Nextension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NEXTENSION");
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFACTURA");
            entity.Property(e => e.Ntelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NTELEFONO");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.Operador)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OPERADOR");
        });

        modelBuilder.Entity<TrgErroresTarificacion977>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_ERRORES_TARIFICACION_977");

            entity.Property(e => e.Abonado)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.AmbitoLlamada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AmbitoLLamada");
            entity.Property(e => e.CodAgrupacionDetalle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodMulticonexion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoDescuento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoDescuentoPer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoRegistro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Destino)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Duracion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Hora)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteAm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ImporteAM");
            entity.Property(e => e.ImporteDescuento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteEstandar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteValor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Locuciones)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("nComercial1");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nfacturainterna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFACTURAINTERNA");
            entity.Property(e => e.Nrecibo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NRecibo");
            entity.Property(e => e.NtelPer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NTelPer");
            entity.Property(e => e.NumeroLlamado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NumeroLLamado");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.OperadorProveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Origen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RefAgrupacionFacturable)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubTipoTrafico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoServicio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoTrafico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoVariable)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unidades)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnidadesVolumen)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrgErroresTarificacionMovil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_ERRORES_TARIFICACION_MOVIL");

            entity.Property(e => e.Abonado)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Cantmedidaoriginada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANTMEDIDAORIGINADA");
            entity.Property(e => e.Cantmedidarecibida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANTMEDIDARECIBIDA");
            entity.Property(e => e.Coddestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODDESTINO");
            entity.Property(e => e.Codllamada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODLLAMADA");
            entity.Property(e => e.Codtrafico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODTRAFICO");
            entity.Property(e => e.Duracion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURACION");
            entity.Property(e => e.Duraciondatos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURACIONDATOS");
            entity.Property(e => e.Fecha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA");
            entity.Property(e => e.Franja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FRANJA");
            entity.Property(e => e.Horainicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HORAINICIO");
            entity.Property(e => e.Importe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE");
            entity.Property(e => e.ImporteAm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE_AM");
            entity.Property(e => e.Importedatos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTEDATOS");
            entity.Property(e => e.Nextension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NEXTENSION");
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFACTURA");
            entity.Property(e => e.Nllamado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLLAMADO");
            entity.Property(e => e.Nregs).HasColumnName("NREGS");
            entity.Property(e => e.Ntelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NTELEFONO");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.Operadordestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPERADORDESTINO");
            entity.Property(e => e.Operadororigen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPERADORORIGEN");
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("TARIFA");
            entity.Property(e => e.Tipodestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPODESTINO");
            entity.Property(e => e.Tipollamada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOLLAMADA");
            entity.Property(e => e.Tipotrafico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOTRAFICO");
            entity.Property(e => e.Unidadmedida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIDADMEDIDA");
        });

        modelBuilder.Entity<TrgErroresTarificacionMovilDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_ERRORES_TARIFICACION_MOVIL_DETALLE");

            entity.Property(e => e.Abonado)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Cantmedidaoriginada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANTMEDIDAORIGINADA");
            entity.Property(e => e.Cantmedidarecibida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANTMEDIDARECIBIDA");
            entity.Property(e => e.Coddestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODDESTINO");
            entity.Property(e => e.Codllamada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODLLAMADA");
            entity.Property(e => e.Codtrafico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODTRAFICO");
            entity.Property(e => e.Duracion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURACION");
            entity.Property(e => e.Duraciondatos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURACIONDATOS");
            entity.Property(e => e.Fecha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA");
            entity.Property(e => e.Franja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FRANJA");
            entity.Property(e => e.Horainicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HORAINICIO");
            entity.Property(e => e.Importe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE");
            entity.Property(e => e.ImporteAm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE_AM");
            entity.Property(e => e.Importedatos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTEDATOS");
            entity.Property(e => e.Nextension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NEXTENSION");
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFACTURA");
            entity.Property(e => e.Nllamado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLLAMADO");
            entity.Property(e => e.Nregs).HasColumnName("NREGS");
            entity.Property(e => e.Ntelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NTELEFONO");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.Operadordestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPERADORDESTINO");
            entity.Property(e => e.Operadororigen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPERADORORIGEN");
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("TARIFA");
            entity.Property(e => e.Tipodestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPODESTINO");
            entity.Property(e => e.Tipollamada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOLLAMADA");
            entity.Property(e => e.Tipotrafico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOTRAFICO");
            entity.Property(e => e.Unidadmedida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIDADMEDIDA");
        });

        modelBuilder.Entity<TrgFacturaGlobal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_FacturaGlobal");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Bimponible).HasColumnName("BImponible");
            entity.Property(e => e.Empresa)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Ppto).HasColumnName("PPto");
            entity.Property(e => e.TipoFactura).HasMaxLength(1);
        });

        modelBuilder.Entity<TrgFacturacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_FACTURACION");

            entity.Property(e => e.Fecha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA");
            entity.Property(e => e.Incidencias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INCIDENCIAS");
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFACTURA");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.Operador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPERADOR");
        });

        modelBuilder.Entity<TrgFacturacionSinDescuadre>(entity =>
        {
            entity.HasKey(e => e.IdFacturacionSinDescuadre);

            entity.ToTable("TRG_FACTURACION_SIN_DESCUADRE");

            entity.Property(e => e.CodProdConcepFact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteAm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ImporteAM");
            entity.Property(e => e.ImporteEstandar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NfacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFacturaInterna");
            entity.Property(e => e.Ntelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NTelefono");
        });

        modelBuilder.Entity<TrgGrupoTraficoMovil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_GRUPO_TRAFICO_MOVIL");

            entity.Property(e => e.IdGrupoTrafico).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StrDescGrupoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_010");

            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.Cif2).HasMaxLength(50);
            entity.Property(e => e.CodPostal).HasMaxLength(50);
            entity.Property(e => e.CodigoAgrupacionAsociacion)
                .HasMaxLength(50)
                .HasColumnName("CodigoAgrupacion_Asociacion");
            entity.Property(e => e.CodigoPostal).HasMaxLength(50);
            entity.Property(e => e.CodigoSoporte).HasMaxLength(50);
            entity.Property(e => e.Domicilio).HasMaxLength(50);
            entity.Property(e => e.Domicilio2).HasMaxLength(50);
            entity.Property(e => e.EMail)
                .HasMaxLength(50)
                .HasColumnName("E_mail");
            entity.Property(e => e.FactorConversion).HasMaxLength(50);
            entity.Property(e => e.FecFacturacion).HasMaxLength(50);
            entity.Property(e => e.FecGeneracionRegistro).HasMaxLength(50);
            entity.Property(e => e.LibNextension)
                .HasMaxLength(50)
                .HasColumnName("libNextension");
            entity.Property(e => e.LibNfactura)
                .HasMaxLength(50)
                .HasColumnName("libNfactura");
            entity.Property(e => e.LibNpreFactura)
                .HasMaxLength(50)
                .HasColumnName("libNpreFactura");
            entity.Property(e => e.LibNtelefono)
                .HasMaxLength(50)
                .HasColumnName("libNtelefono");
            entity.Property(e => e.Libre).HasMaxLength(207);
            entity.Property(e => e.Localidad).HasMaxLength(50);
            entity.Property(e => e.Localidad2).HasMaxLength(50);
            entity.Property(e => e.Moneda).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(65);
            entity.Property(e => e.Nombre2).HasMaxLength(65);
            entity.Property(e => e.Nombre3).HasMaxLength(65);
            entity.Property(e => e.NombreFichero).HasMaxLength(50);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoSoporte).HasMaxLength(50);
            entity.Property(e => e.VersionSoporte).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr030>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_030");

            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.CodPostal).HasMaxLength(50);
            entity.Property(e => e.Domicilio).HasMaxLength(50);
            entity.Property(e => e.LibNextension)
                .HasMaxLength(50)
                .HasColumnName("libNextension");
            entity.Property(e => e.LibNfactura)
                .HasMaxLength(50)
                .HasColumnName("libNfactura");
            entity.Property(e => e.LibNpreFactura)
                .HasMaxLength(50)
                .HasColumnName("libNpreFactura");
            entity.Property(e => e.LibNtelefono)
                .HasMaxLength(50)
                .HasColumnName("libNtelefono");
            entity.Property(e => e.Libre).HasMaxLength(484);
            entity.Property(e => e.Localidad).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(65);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr050>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_050");

            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.CodConcierto).HasMaxLength(50);
            entity.Property(e => e.CodServicio).HasMaxLength(50);
            entity.Property(e => e.DescConcierto).HasMaxLength(50);
            entity.Property(e => e.DescServicio).HasMaxLength(50);
            entity.Property(e => e.ImpConcertado).HasMaxLength(50);
            entity.Property(e => e.LibNextension)
                .HasMaxLength(50)
                .HasColumnName("libNextension");
            entity.Property(e => e.LibNfactura)
                .HasMaxLength(50)
                .HasColumnName("libNfactura");
            entity.Property(e => e.LibNpreFactura)
                .HasMaxLength(50)
                .HasColumnName("libNpreFactura");
            entity.Property(e => e.LibNtelefono)
                .HasMaxLength(50)
                .HasColumnName("libNtelefono");
            entity.Property(e => e.Libre).HasMaxLength(420);
            entity.Property(e => e.MonedaConcierto).HasMaxLength(50);
            entity.Property(e => e.PerEmision).HasMaxLength(50);
            entity.Property(e => e.PerRegular).HasMaxLength(50);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.ServicioConcert).HasMaxLength(50);
            entity.Property(e => e.TipoConcierto).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.VersionConcierto).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr100>(entity =>
        {
            entity.HasKey(e => new { e.SecuenciaRegistro, e.LibNfactura });

            entity.ToTable("TRG_MVSTR_100");

            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.LibNfactura)
                .HasMaxLength(50)
                .HasColumnName("libNfactura");
            entity.Property(e => e.Banco).HasMaxLength(50);
            entity.Property(e => e.BaseImponible).HasMaxLength(50);
            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.Cuenta).HasMaxLength(50);
            entity.Property(e => e.Dc)
                .HasMaxLength(50)
                .HasColumnName("DC");
            entity.Property(e => e.FechFactura).HasMaxLength(50);
            entity.Property(e => e.Impuesto).HasMaxLength(50);
            entity.Property(e => e.LibNextension)
                .HasMaxLength(50)
                .HasColumnName("libNextension");
            entity.Property(e => e.LibNpreFactura)
                .HasMaxLength(50)
                .HasColumnName("libNpreFactura");
            entity.Property(e => e.LibNtelefono)
                .HasMaxLength(50)
                .HasColumnName("libNtelefono");
            entity.Property(e => e.Libre).HasMaxLength(380);
            entity.Property(e => e.MonedaOriginal).HasMaxLength(50);
            entity.Property(e => e.Nlfijas)
                .HasMaxLength(50)
                .HasColumnName("NLFijas");
            entity.Property(e => e.Nlmoviles)
                .HasMaxLength(50)
                .HasColumnName("NLMoviles");
            entity.Property(e => e.Servivio).HasMaxLength(50);
            entity.Property(e => e.Sucursal).HasMaxLength(50);
            entity.Property(e => e.SumaTotal).HasMaxLength(50);
            entity.Property(e => e.Tipo).HasMaxLength(50);
            entity.Property(e => e.TipoContrato).HasMaxLength(50);
            entity.Property(e => e.TipoFactura).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.TotalCuotas).HasMaxLength(50);
            entity.Property(e => e.TotalDescuentos).HasMaxLength(50);
            entity.Property(e => e.TotalImpuestos).HasMaxLength(50);
            entity.Property(e => e.TotalPagar).HasMaxLength(50);
            entity.Property(e => e.TotalServicios).HasMaxLength(50);
            entity.Property(e => e.TotalVarios).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr200>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_200");

            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.Fechprefactura).HasMaxLength(50);
            entity.Property(e => e.LibNextension)
                .HasMaxLength(50)
                .HasColumnName("libNextension");
            entity.Property(e => e.LibNtel5efono)
                .HasMaxLength(50)
                .HasColumnName("libNtel5efono");
            entity.Property(e => e.Libre).HasMaxLength(468);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nlfijas)
                .HasMaxLength(50)
                .HasColumnName("NLFijas");
            entity.Property(e => e.Nlmoviles)
                .HasMaxLength(50)
                .HasColumnName("NLMoviles");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.Servivio).HasMaxLength(50);
            entity.Property(e => e.SumaTotal).HasMaxLength(50);
            entity.Property(e => e.TipoContrato).HasMaxLength(50);
            entity.Property(e => e.TipoPrefactura).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.TotalCuotas).HasMaxLength(50);
            entity.Property(e => e.TotalDescuentos).HasMaxLength(50);
            entity.Property(e => e.TotalServicios).HasMaxLength(50);
            entity.Property(e => e.TotalVarios).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr300>(entity =>
        {
            entity.HasKey(e => new { e.SecuenciaRegistro, e.Nfactura });

            entity.ToTable("TRG_MVSTR_300");

            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Cargos).HasMaxLength(50);
            entity.Property(e => e.CodigoCc)
                .HasMaxLength(50)
                .HasColumnName("CodigoCC");
            entity.Property(e => e.DescripcionCc)
                .HasMaxLength(50)
                .HasColumnName("DescripcionCC");
            entity.Property(e => e.DescuentoCuotas).HasMaxLength(50);
            entity.Property(e => e.DescuentoServicio).HasMaxLength(50);
            entity.Property(e => e.Libre).HasMaxLength(414);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.ProporcionCargos).HasMaxLength(50);
            entity.Property(e => e.ProporcionDctoCuotas).HasMaxLength(50);
            entity.Property(e => e.ProporcionDctoServicio).HasMaxLength(50);
            entity.Property(e => e.SumaTotal).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.TotalCuotas).HasMaxLength(50);
            entity.Property(e => e.TotalDescuentos).HasMaxLength(50);
            entity.Property(e => e.TotalServicioFranq).HasMaxLength(50);
            entity.Property(e => e.TotalServicioMedido).HasMaxLength(50);
            entity.Property(e => e.TotalVarios).HasMaxLength(50);
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr310>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_310");

            entity.Property(e => e.CodigoCuota).HasMaxLength(50);
            entity.Property(e => e.DescripcionCuota).HasMaxLength(50);
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.Importe).HasMaxLength(50);
            entity.Property(e => e.Libre).HasMaxLength(87);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr320>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_320");

            entity.Property(e => e.CantidadFranq).HasMaxLength(50);
            entity.Property(e => e.CantidadMedida).HasMaxLength(50);
            entity.Property(e => e.CodigoTipoTrafico).HasMaxLength(50);
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.ImporteFranq).HasMaxLength(50);
            entity.Property(e => e.Importes).HasMaxLength(50);
            entity.Property(e => e.Libre).HasMaxLength(50);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nllamadas)
                .HasMaxLength(50)
                .HasColumnName("NLlamadas");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
            entity.Property(e => e.UnidadMedida).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr330>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_330");

            entity.Property(e => e.CalidadSuministrada).HasMaxLength(50);
            entity.Property(e => e.CantidadMedidaOrig).HasMaxLength(50);
            entity.Property(e => e.CantidadMedidaRecib).HasMaxLength(50);
            entity.Property(e => e.CodAbreLlamada).HasMaxLength(50);
            entity.Property(e => e.CodDestino).HasMaxLength(50);
            entity.Property(e => e.CodHorario).HasMaxLength(50);
            entity.Property(e => e.CodigoTipoTrafico).HasMaxLength(50);
            entity.Property(e => e.DescTipoLlamada).HasMaxLength(50);
            entity.Property(e => e.ExcedeLimiteDuracion).HasColumnName("EXCEDE_LIMITE_DURACION");
            entity.Property(e => e.Fecha).HasMaxLength(50);
            entity.Property(e => e.HoraInicio).HasMaxLength(50);
            entity.Property(e => e.Importe).HasMaxLength(50);
            entity.Property(e => e.Libre).HasMaxLength(50);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nllamado)
                .HasMaxLength(50)
                .HasColumnName("NLlamado");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.Operador).HasMaxLength(50);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoDestino).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
            entity.Property(e => e.UnidadCalidad).HasMaxLength(50);
            entity.Property(e => e.UnidadMedida).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr340>(entity =>
        {
            entity.HasKey(e => new { e.SecuenciaRegistro, e.Nfactura, e.Ntelefono, e.CodigoVario });

            entity.ToTable("TRG_MVSTR_340");

            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.CodigoVario).HasMaxLength(50);
            entity.Property(e => e.DescVario).HasMaxLength(100);
            entity.Property(e => e.Importe).HasMaxLength(50);
            entity.Property(e => e.Libre).HasMaxLength(60);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr350>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_350");

            entity.Property(e => e.CantidadMedida).HasMaxLength(50);
            entity.Property(e => e.CodigoTrafico).HasMaxLength(50);
            entity.Property(e => e.Descuento).HasMaxLength(50);
            entity.Property(e => e.ImporteUniMedida).HasMaxLength(50);
            entity.Property(e => e.Libre).HasMaxLength(57);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
            entity.Property(e => e.TramoFinal).HasMaxLength(50);
            entity.Property(e => e.TramoInicial).HasMaxLength(50);
            entity.Property(e => e.UnidadMedida).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr700>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_700");

            entity.Property(e => e.CodigoCargo).HasMaxLength(50);
            entity.Property(e => e.DescCargo).HasMaxLength(100);
            entity.Property(e => e.Importe).HasMaxLength(50);
            entity.Property(e => e.Libre).HasMaxLength(60);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr750>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_750");

            entity.Property(e => e.CodTipoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.DescDescuento).HasMaxLength(50);
            entity.Property(e => e.DescuentoGlobal).HasMaxLength(50);
            entity.Property(e => e.Importe).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.IndDescuentoGlobal).HasMaxLength(50);
            entity.Property(e => e.IndTramo).HasMaxLength(50);
            entity.Property(e => e.Libre).HasMaxLength(50);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.PorcenDescuento).HasMaxLength(50);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.TramoBase).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr800>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_800");

            entity.Property(e => e.CodigoCargo).HasMaxLength(50);
            entity.Property(e => e.DescCargo).HasMaxLength(100);
            entity.Property(e => e.ImporteTotal).HasMaxLength(50);
            entity.Property(e => e.ImporteUnitario).HasMaxLength(50);
            entity.Property(e => e.Libre).HasMaxLength(81);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.Unidades).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr850>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_850");

            entity.Property(e => e.CodTipoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.DescDescuento).HasMaxLength(50);
            entity.Property(e => e.DescuentoGlobal).HasMaxLength(50);
            entity.Property(e => e.Importe).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.IndDescuentoGlobal).HasMaxLength(50);
            entity.Property(e => e.IndTramo).HasMaxLength(50);
            entity.Property(e => e.Libre).HasMaxLength(50);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.PorcenDescuento).HasMaxLength(50);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.TramoBase).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr950>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_950");

            entity.Property(e => e.Cif)
                .HasMaxLength(50)
                .HasColumnName("CIF");
            entity.Property(e => e.CodServicio).HasMaxLength(50);
            entity.Property(e => e.DecsServicio).HasMaxLength(50);
            entity.Property(e => e.Libre).HasMaxLength(472);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.SumaTotal).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.TotalCuotas).HasMaxLength(50);
            entity.Property(e => e.TotalDescuentos).HasMaxLength(50);
            entity.Property(e => e.TotalFacturas).HasMaxLength(50);
            entity.Property(e => e.TotalFijos).HasMaxLength(50);
            entity.Property(e => e.TotalImpuestos).HasMaxLength(50);
            entity.Property(e => e.TotalMoviles).HasMaxLength(50);
            entity.Property(e => e.TotalPrefacturas).HasMaxLength(50);
            entity.Property(e => e.TotalRegistros).HasMaxLength(50);
            entity.Property(e => e.TotalServMedio).HasMaxLength(50);
            entity.Property(e => e.TotalVarios).HasMaxLength(50);
            entity.Property(e => e.TotalesPagar).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr970>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_970");

            entity.Property(e => e.Cif)
                .HasMaxLength(50)
                .HasColumnName("CIF");
            entity.Property(e => e.Libre).HasMaxLength(455);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.SumaTotal).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.TotalCuotas).HasMaxLength(50);
            entity.Property(e => e.TotalDescuentos).HasMaxLength(50);
            entity.Property(e => e.TotalFacturas).HasMaxLength(50);
            entity.Property(e => e.TotalFijos).HasMaxLength(50);
            entity.Property(e => e.TotalImpuestos).HasMaxLength(50);
            entity.Property(e => e.TotalMoviles).HasMaxLength(50);
            entity.Property(e => e.TotalPrefacturas).HasMaxLength(50);
            entity.Property(e => e.TotalRegistros).HasMaxLength(50);
            entity.Property(e => e.TotalServMedio).HasMaxLength(50);
            entity.Property(e => e.TotalServicios).HasMaxLength(50);
            entity.Property(e => e.TotalVarios).HasMaxLength(50);
            entity.Property(e => e.TotalesPagar).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstr990>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_MVSTR_990");

            entity.Property(e => e.CodAgrup).HasMaxLength(50);
            entity.Property(e => e.CodSoporte).HasMaxLength(50);
            entity.Property(e => e.Libre).HasMaxLength(412);
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nprefactura)
                .HasMaxLength(50)
                .HasColumnName("NPrefactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
            entity.Property(e => e.SecuenciaRegistro).HasMaxLength(50);
            entity.Property(e => e.SumaTotal).HasMaxLength(50);
            entity.Property(e => e.TipoRegistro).HasMaxLength(50);
            entity.Property(e => e.TotalClientes).HasMaxLength(50);
            entity.Property(e => e.TotalCuotas).HasMaxLength(50);
            entity.Property(e => e.TotalDescuentos).HasMaxLength(50);
            entity.Property(e => e.TotalFacturas).HasMaxLength(50);
            entity.Property(e => e.TotalFijos).HasMaxLength(50);
            entity.Property(e => e.TotalImpuestos).HasMaxLength(50);
            entity.Property(e => e.TotalMoviles).HasMaxLength(50);
            entity.Property(e => e.TotalPrefacturas).HasMaxLength(50);
            entity.Property(e => e.TotalRegistros).HasMaxLength(50);
            entity.Property(e => e.TotalServMedio).HasMaxLength(50);
            entity.Property(e => e.TotalServicios).HasMaxLength(50);
            entity.Property(e => e.TotalVarios).HasMaxLength(50);
            entity.Property(e => e.TotalesPagar).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgMvstrFactura>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_MVSTR_factura");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Cif).HasMaxLength(50);
            entity.Property(e => e.Empresa)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.FechFactura).HasMaxLength(50);
            entity.Property(e => e.Impuesto).HasMaxLength(50);
            entity.Property(e => e.LibNfactura)
                .HasMaxLength(50)
                .HasColumnName("libNfactura");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Tipo).HasMaxLength(50);
            entity.Property(e => e.TipoContrato).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgOrngAnexo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_ORNG_Anexo");
        });

        modelBuilder.Entity<TrgOrngCabeceraFactura>(entity =>
        {
            entity.HasKey(e => e.NFactura);

            entity.ToTable("TRG_ORNG_CabeceraFactura");

            entity.Property(e => e.NFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nFactura");
            entity.Property(e => e.CargosBajoCons)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CargosImporte)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ccorriente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConsLlamadas)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConsMenServDat)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConsServEsp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DirCliente)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DirContacto)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EntFinanciera)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fFactura");
            entity.Property(e => e.Iva)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MetPago)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NifCif)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OtrosCargos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PFacturado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pFacturado");
            entity.Property(e => e.PagoApartir)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PagoAPartir");
            entity.Property(e => e.Total)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalAntesI)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalCargos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalPagar)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrgOrngConceptosDatos>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_ORNG_ConceptosDatos");

            entity.Property(e => e.Fecha)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Franja)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoraEnvio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nFactura");
            entity.Property(e => e.NTelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nTelefono");
            entity.Property(e => e.PlanPrecio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Servicio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Volumen)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrgOrngConceptosEspeciales>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_ORNG_ConceptosEspeciales");

            entity.Property(e => e.CifProveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DuracionVolumen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Inicio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NDestino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nDestino");
            entity.Property(e => e.NFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nFactura");
            entity.Property(e => e.NTelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nTelefono");
            entity.Property(e => e.Proveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoServicio)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrgOrngConceptosMensajes>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_ORNG_ConceptosMensajes");

            entity.Property(e => e.DestinoOperador)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Franja)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoraEnvio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nFactura");
            entity.Property(e => e.NTelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nTelefono");
            entity.Property(e => e.NumeroDestino)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoMensaje)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrgOrngConceptosNacionales>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_ORNG_ConceptosNacionales");

            entity.Property(e => e.DestinoOperador)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Duracion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Franja)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Inicio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nFactura");
            entity.Property(e => e.NTelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nTelefono");
            entity.Property(e => e.NumeroDestino)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrgOrngConceptosOtrosCargos>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_ORNG_ConceptosOtrosCargos");

            entity.Property(e => e.Concepto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteTotal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nFactura");
            entity.Property(e => e.NTelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nTelefono");
        });

        modelBuilder.Entity<TrgOrngDesgloseFactura>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_ORNG_DesgloseFactura");

            entity.Property(e => e.CargosBajoConsumo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cuotas)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Datos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Especiales)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Internacional)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mensajes)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nFactura");
            entity.Property(e => e.NTelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nTelefono");
            entity.Property(e => e.Nacional)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Roaming)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rpv)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrgTarifasPlanas>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TarifasPlanas");

            entity.Property(e => e.Bloque)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LimiteConsumo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioBloque)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioLimite)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioMaximo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrgTarifasPlanasDatos>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TarifasPlanasDatos");

            entity.Property(e => e.Bloque)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoTipoTrafico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.Idoperadora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IDOperadora");
            entity.Property(e => e.LimiteConsumo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioBloque)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioLimite)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioMaximo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SinlimiteConsumo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoTarifa)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrgTarifasPlanasVoz>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("TRG_TarifasPlanasVoz");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CuotaMensual)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstLlamada)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Franquicia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioMinuto)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrgTarificacion977>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TARIFICACION_977");

            entity.Property(e => e.Abonado)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ImporteTotal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE_TOTAL");
            entity.Property(e => e.ImporteTotalAm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE_TOTAL_AM");
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFACTURA");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
        });

        modelBuilder.Entity<TrgTarificacionMovil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TARIFICACION_MOVIL");

            entity.Property(e => e.Abonado)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Fecha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA");
            entity.Property(e => e.ImporteTotal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE_TOTAL");
            entity.Property(e => e.ImporteTotalAm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE_TOTAL_AM");
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFACTURA");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.Operadororigen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPERADORORIGEN");
        });

        modelBuilder.Entity<TrgTarificacionSinDescuadre>(entity =>
        {
            entity.HasKey(e => e.IdTarificacionSinDescuadre);

            entity.ToTable("TRG_TARIFICACION_SIN_DESCUADRE");

            entity.Property(e => e.AmbitoLlamada)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Destino)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteAm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ImporteAM");
            entity.Property(e => e.ImporteEstandar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NfacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NFacturaInterna");
            entity.Property(e => e.Origen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrgTel977000000>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_000000");

            entity.Property(e => e.CifSupracliente).HasMaxLength(50);
            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoPostal).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.Domicilio).HasMaxLength(50);
            entity.Property(e => e.DuplicadoRegular)
                .HasMaxLength(50)
                .HasColumnName("Duplicado_Regular");
            entity.Property(e => e.FechaEmision).HasMaxLength(50);
            entity.Property(e => e.FechaVersion).HasMaxLength(50);
            entity.Property(e => e.IdentificacionTipoAcuerdo).HasMaxLength(50);
            entity.Property(e => e.IdentificadorUnico).HasMaxLength(50);
            entity.Property(e => e.LineaEtiqueta1).HasMaxLength(56);
            entity.Property(e => e.LineaEtiqueta2).HasMaxLength(50);
            entity.Property(e => e.Localidad).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.LongitudArchivo).HasMaxLength(50);
            entity.Property(e => e.NAgfmonoservicio)
                .HasMaxLength(50)
                .HasColumnName("nAGFmonoservicio");
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NRegistrosTotales)
                .HasMaxLength(50)
                .HasColumnName("nRegistrosTotales");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NombreArchivoPc)
                .HasMaxLength(50)
                .HasColumnName("NombreArchivoPC");
            entity.Property(e => e.NombreEemisora).HasMaxLength(70);
            entity.Property(e => e.NombreSupracliente).HasMaxLength(70);
            entity.Property(e => e.Provincia).HasMaxLength(50);
            entity.Property(e => e.ReceptorSoporte).HasMaxLength(65);
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.TipoCambio).HasMaxLength(50);
            entity.Property(e => e.TipoFacturacion).HasMaxLength(50);
            entity.Property(e => e.TipoImpuesto).HasMaxLength(50);
            entity.Property(e => e.TipoMoneda).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoSoporte).HasMaxLength(50);
            entity.Property(e => e.Version997).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977100000>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_100000");

            entity.Property(e => e.CifSupracliente).HasMaxLength(50);
            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoControl).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.ImpTotalSumFacSupracliente)
                .HasMaxLength(50)
                .HasColumnName("_ImpTotalSumFacSupracliente");
            entity.Property(e => e.ImpTotalSupracliente).HasMaxLength(50);
            entity.Property(e => e.ImporteImpuestos).HasMaxLength(50);
            entity.Property(e => e.ImportePromociones).HasMaxLength(50);
            entity.Property(e => e.ImporteRedondeo).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NombreSupracliente).HasMaxLength(70);
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977100000DetC6>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_100000_DET_C6");

            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.ImporteConcepto).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977200000>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_200000");

            entity.Property(e => e.CifCliente).HasMaxLength(50);
            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoControl).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.ImpTotalCliente).HasMaxLength(50);
            entity.Property(e => e.ImpTotalSumFacCliente)
                .HasMaxLength(50)
                .HasColumnName("_ImpTotalSumFacCliente");
            entity.Property(e => e.ImporteImpuestos).HasMaxLength(50);
            entity.Property(e => e.ImportePromociones).HasMaxLength(50);
            entity.Property(e => e.ImporteRedondeo).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NombreCliente).HasMaxLength(70);
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977200000DetC6>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_200000_DET_C6");

            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.ImporteConcepto).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977300000>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_300000");

            entity.Property(e => e.CifEntidadEmisora).HasMaxLength(50);
            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoControl).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.DatosCobro).HasMaxLength(50);
            entity.Property(e => e.DescripcionCargo).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.FechaEmision).HasMaxLength(50);
            entity.Property(e => e.FechaPuestaCobro).HasMaxLength(50);
            entity.Property(e => e.Identificacion).HasMaxLength(50);
            entity.Property(e => e.ImporteFactura).HasMaxLength(50);
            entity.Property(e => e.ImportePagarMasPromociones).HasMaxLength(50);
            entity.Property(e => e.ImportePromociones).HasMaxLength(50);
            entity.Property(e => e.ImporteRedondeo).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NumeroFactura).HasMaxLength(50);
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConceptoC5)
                .HasMaxLength(50)
                .HasColumnName("_RepeticionesConceptoC5");
            entity.Property(e => e.RepeticionesConceptoC6)
                .HasMaxLength(50)
                .HasColumnName("_RepeticionesConceptoC6");
            entity.Property(e => e.STablaControl)
                .HasMaxLength(80)
                .HasColumnName("sTablaControl");
            entity.Property(e => e.TipoImpuesto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TitularPostal).HasMaxLength(65);
        });

        modelBuilder.Entity<TrgTel977300000DetB2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_300000_DET_B2");

            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NumeroRegistros).HasMaxLength(50);
            entity.Property(e => e.Numeroocurrencias).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977300000DetC5>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_300000_DET_C5");

            entity.Property(e => e.BaseImponible).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteImpuesto).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
            entity.Property(e => e.TipoImpositivo).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977300000DetC6>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_300000_DET_C6");

            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteConcepto).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977301010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_301010");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977301010DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_301010_DET_C2");

            entity.Property(e => e.CodDesPeriodo1).HasMaxLength(50);
            entity.Property(e => e.CodDesPeriodo2).HasMaxLength(50);
            entity.Property(e => e.CodPaquete).HasMaxLength(50);
            entity.Property(e => e.CodProdConcepFact).HasMaxLength(50);
            entity.Property(e => e.CodProdPers).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.ImporteDistancia).HasMaxLength(50);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteTotal).HasMaxLength(50);
            entity.Property(e => e.ImporteUnitario).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
            entity.Property(e => e.Nunidades)
                .HasMaxLength(50)
                .HasColumnName("NUnidades");
            entity.Property(e => e.NunidadesPeriodo1)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo1");
            entity.Property(e => e.NunidadesPeriodo2)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo2");
            entity.Property(e => e.TipoImpositivo).HasMaxLength(50);
            entity.Property(e => e.TipoValoracion).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977301010DetC218>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_301010_DET_C2_18");

            entity.Property(e => e.CodDesApli).HasMaxLength(50);
            entity.Property(e => e.CodDesPers).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977301020>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_301020");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977301020DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_301020_DET_C2");

            entity.Property(e => e.CodPaquete).HasMaxLength(50);
            entity.Property(e => e.CodProdConcepFact).HasMaxLength(50);
            entity.Property(e => e.CodProdPers).HasMaxLength(50);
            entity.Property(e => e.CodigoDesPeriodo1).HasMaxLength(50);
            entity.Property(e => e.CodigoDesPeriodo2).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.ImporteDistancia).HasMaxLength(50);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteTotal).HasMaxLength(50);
            entity.Property(e => e.ImporteUnitario).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
            entity.Property(e => e.Nsolicitud)
                .HasMaxLength(50)
                .HasColumnName("NSolicitud");
            entity.Property(e => e.Nunidades)
                .HasMaxLength(50)
                .HasColumnName("NUnidades");
            entity.Property(e => e.NunidadesPeriodo1)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo1");
            entity.Property(e => e.NunidadesPeriodo2)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo2");
            entity.Property(e => e.TipoImpositivo).HasMaxLength(50);
            entity.Property(e => e.TipoValoracion).HasMaxLength(50);
            entity.Property(e => e.Zona).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977301020DetC220>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_301020_DET_C2_20");

            entity.Property(e => e.CodDesPers).HasMaxLength(50);
            entity.Property(e => e.CodigoAplicado).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977303010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_303010");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977303010DetC1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_303010_DET_C1");

            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPers).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinPeriodo).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.ImporteSujetoDescuento).HasMaxLength(50);
            entity.Property(e => e.InicioPeriodo).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977304010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_304010");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977304010DetC1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_304010_DET_C1");

            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteConcepto).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977500000>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_500000");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoControl).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ImporteNetoTotalServicio).HasMaxLength(50);
            entity.Property(e => e.ImportePromOtrosCargRepercut).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto)
                .HasMaxLength(50)
                .HasColumnName("_RepeticionesConcepto");
            entity.Property(e => e.STablaControl)
                .HasMaxLength(80)
                .HasColumnName("sTablaControl");
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977500000DetC3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_500000_DET_C3");

            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteConcepto).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977501010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_501010");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977501010DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_501010_DET_C2");

            entity.Property(e => e.CodDesPeriodo1).HasMaxLength(50);
            entity.Property(e => e.CodDesPeriodo2).HasMaxLength(50);
            entity.Property(e => e.CodPaquete).HasMaxLength(50);
            entity.Property(e => e.CodProdConcepFact).HasMaxLength(50);
            entity.Property(e => e.CodProdPers).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.ImporteDistancia).HasMaxLength(50);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteTotal).HasMaxLength(50);
            entity.Property(e => e.ImporteUnitario).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
            entity.Property(e => e.Nunidades)
                .HasMaxLength(50)
                .HasColumnName("NUnidades");
            entity.Property(e => e.NunidadesPeriodo1)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo1");
            entity.Property(e => e.NunidadesPeriodo2)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo2");
            entity.Property(e => e.TipoImpositivo).HasMaxLength(50);
            entity.Property(e => e.TipoValoracion).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977501010DetC218>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_501010_DET_C2_18");

            entity.Property(e => e.CodDesApli).HasMaxLength(50);
            entity.Property(e => e.CodDesPers).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977501020>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_501020");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977501020DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_501020_DET_C2");

            entity.Property(e => e.CodPaquete).HasMaxLength(50);
            entity.Property(e => e.CodProdConcepFact).HasMaxLength(50);
            entity.Property(e => e.CodProdPers).HasMaxLength(50);
            entity.Property(e => e.CodigoDesPeriodo1).HasMaxLength(50);
            entity.Property(e => e.CodigoDesPeriodo2).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.ImporteDistancia).HasMaxLength(50);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteTotal).HasMaxLength(50);
            entity.Property(e => e.ImporteUnitario).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
            entity.Property(e => e.Nsolicitud)
                .HasMaxLength(50)
                .HasColumnName("NSolicitud");
            entity.Property(e => e.Nunidades)
                .HasMaxLength(50)
                .HasColumnName("NUnidades");
            entity.Property(e => e.NunidadesPeriodo1)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo1");
            entity.Property(e => e.NunidadesPeriodo2)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo2");
            entity.Property(e => e.TipoImpositivo).HasMaxLength(50);
            entity.Property(e => e.TipoValoracion).HasMaxLength(50);
            entity.Property(e => e.Zona).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977501020DetC220>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_501020_DET_C2_20");

            entity.Property(e => e.CodDesPers).HasMaxLength(50);
            entity.Property(e => e.CodigoAplicado).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977503010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_503010");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977503010DetC1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_503010_DET_C1");

            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPers).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinPeriodo).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.ImporteSujetoDescuento).HasMaxLength(50);
            entity.Property(e => e.InicioPeriodo).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977504010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_504010");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977504010DetC1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_504010_DET_C1");

            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteConcepto).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977600000>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_600000");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoControl).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.DescripcionMulticonexion).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ImporteNetoTotalMultiCon).HasMaxLength(50);
            entity.Property(e => e.ImportePromOtrosCargAsoc).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto)
                .HasMaxLength(50)
                .HasColumnName("_RepeticionesConcepto");
            entity.Property(e => e.STablaControl)
                .HasMaxLength(80)
                .HasColumnName("sTablaControl");
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977600000DetB2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_600000_DET_B2");

            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NumeroRegistros).HasMaxLength(50);
            entity.Property(e => e.Numeroocurrencias).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977600000DetC3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_600000_DET_C3");

            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteConcepto).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977600040>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_600040");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977600040DetC1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_600040_DET_C1");

            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinTramo).HasMaxLength(50);
            entity.Property(e => e.InicioTramo).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977601010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_601010");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977601010DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_601010_DET_C2");

            entity.Property(e => e.CodDesPeriodo1).HasMaxLength(50);
            entity.Property(e => e.CodDesPeriodo2).HasMaxLength(50);
            entity.Property(e => e.CodPaquete).HasMaxLength(50);
            entity.Property(e => e.CodProdConcepFact).HasMaxLength(50);
            entity.Property(e => e.CodProdPers).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.ImporteDistancia).HasMaxLength(50);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteTotal).HasMaxLength(50);
            entity.Property(e => e.ImporteUnitario).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
            entity.Property(e => e.Nunidades)
                .HasMaxLength(50)
                .HasColumnName("NUnidades");
            entity.Property(e => e.NunidadesPeriodo1)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo1");
            entity.Property(e => e.NunidadesPeriodo2)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo2");
            entity.Property(e => e.TipoImpositivo).HasMaxLength(50);
            entity.Property(e => e.TipoValoracion).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977601010DetC218>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_601010_DET_C2_18");

            entity.Property(e => e.CodDesApli).HasMaxLength(50);
            entity.Property(e => e.CodDesPers).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977601020>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_601020");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977601020DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_601020_DET_C2");

            entity.Property(e => e.CodPaquete).HasMaxLength(50);
            entity.Property(e => e.CodProdConcepFact).HasMaxLength(50);
            entity.Property(e => e.CodProdPers).HasMaxLength(50);
            entity.Property(e => e.CodigoDesPeriodo1).HasMaxLength(50);
            entity.Property(e => e.CodigoDesPeriodo2).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.ImporteDistancia).HasMaxLength(50);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteTotal).HasMaxLength(50);
            entity.Property(e => e.ImporteUnitario).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
            entity.Property(e => e.Nsolicitud)
                .HasMaxLength(50)
                .HasColumnName("NSolicitud");
            entity.Property(e => e.Nunidades)
                .HasMaxLength(50)
                .HasColumnName("NUnidades");
            entity.Property(e => e.NunidadesPeriodo1)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo1");
            entity.Property(e => e.NunidadesPeriodo2)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo2");
            entity.Property(e => e.TipoImpositivo).HasMaxLength(50);
            entity.Property(e => e.TipoValoracion).HasMaxLength(50);
            entity.Property(e => e.Zona).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977601020DetC220>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_601020_DET_C2_20");

            entity.Property(e => e.CodDesPers).HasMaxLength(50);
            entity.Property(e => e.CodigoAplicado).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977603010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_603010");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977603010DetC1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_603010_DET_C1");

            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPers).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinPeriodo).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.ImporteSujetoDescuento).HasMaxLength(50);
            entity.Property(e => e.InicioPeriodo).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977604010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_604010");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977604010DetC1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_604010_DET_C1");

            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteConcepto).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977700000>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_700000");

            entity.Property(e => e.Beneficiario).HasMaxLength(50);
            entity.Property(e => e.CentralDestino).HasMaxLength(50);
            entity.Property(e => e.CentralOrigen).HasMaxLength(50);
            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoPostal).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.Distancia).HasMaxLength(50);
            entity.Property(e => e.DomicilioTa)
                .HasMaxLength(50)
                .HasColumnName("DomicilioTA");
            entity.Property(e => e.DomicilioTb)
                .HasMaxLength(50)
                .HasColumnName("DomicilioTB");
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.FechaAlta).HasMaxLength(50);
            entity.Property(e => e.FechaBaja).HasMaxLength(50);
            entity.Property(e => e.ImporteNetoTotLinea).HasMaxLength(50);
            entity.Property(e => e.ImportePromOtrosCargosAsoc).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NombreProv).HasMaxLength(50);
            entity.Property(e => e.PoblacionTa)
                .HasMaxLength(50)
                .HasColumnName("PoblacionTA");
            entity.Property(e => e.PoblacionTb)
                .HasMaxLength(50)
                .HasColumnName("PoblacionTB");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.STablaControl)
                .HasMaxLength(240)
                .HasColumnName("sTablaControl");
            entity.Property(e => e.SituacionAbono).HasMaxLength(50);
            entity.Property(e => e.Subservicio2).HasMaxLength(50);
            entity.Property(e => e.Subservicio3).HasMaxLength(50);
            entity.Property(e => e.Subservicio4).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTarjeta).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977700000DetB1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_700000_DET_B1");

            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NumeroRegistros).HasMaxLength(50);
            entity.Property(e => e.Numeroocurrencias).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977700000DetC3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_700000_DET_C3");

            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaFin).HasMaxLength(50);
            entity.Property(e => e.FechaInicio).HasMaxLength(50);
            entity.Property(e => e.ImporteConcepto).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977700005>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_700005");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoObra).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.CoefHabilitacion).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSala)
                .HasMaxLength(50)
                .HasColumnName("nSala");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NSolicitud)
                .HasMaxLength(50)
                .HasColumnName("nSolicitud");
            entity.Property(e => e.NombreCentral).HasMaxLength(50);
            entity.Property(e => e.PotenciaMaxCalterna)
                .HasMaxLength(50)
                .HasColumnName("PotenciaMaxCAlterna");
            entity.Property(e => e.PotenciaMaxCcontinua)
                .HasMaxLength(50)
                .HasColumnName("PotenciaMaxCContinua");
            entity.Property(e => e.PrecioKwh)
                .HasMaxLength(50)
                .HasColumnName("PrecioKWH");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.SuperficieContratada).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977701010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_701010");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977701010DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_701010_DET_C2");

            entity.Property(e => e.CodDesPeriodo1).HasMaxLength(50);
            entity.Property(e => e.CodDesPeriodo2).HasMaxLength(50);
            entity.Property(e => e.CodPaquete).HasMaxLength(50);
            entity.Property(e => e.CodProdConcepFact).HasMaxLength(50);
            entity.Property(e => e.CodProdPers).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.ImporteDistancia).HasMaxLength(50);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteTotal).HasMaxLength(50);
            entity.Property(e => e.ImporteUnitario).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
            entity.Property(e => e.Nunidades)
                .HasMaxLength(50)
                .HasColumnName("NUnidades");
            entity.Property(e => e.NunidadesPeriodo1)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo1");
            entity.Property(e => e.NunidadesPeriodo2)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo2");
            entity.Property(e => e.TipoImpositivo).HasMaxLength(50);
            entity.Property(e => e.TipoValoracion).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977701010DetC218>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_701010_DET_C2_18");

            entity.Property(e => e.CodDesApli).HasMaxLength(50);
            entity.Property(e => e.CodDesPers).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977701020>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_701020");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977701020DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_701020_DET_C2");

            entity.Property(e => e.CodPaquete).HasMaxLength(50);
            entity.Property(e => e.CodProdConcepFact).HasMaxLength(50);
            entity.Property(e => e.CodProdPers).HasMaxLength(50);
            entity.Property(e => e.CodigoDesPeriodo1).HasMaxLength(50);
            entity.Property(e => e.CodigoDesPeriodo2).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.ImporteDistancia).HasMaxLength(50);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteTotal).HasMaxLength(50);
            entity.Property(e => e.ImporteUnitario).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
            entity.Property(e => e.Nsolicitud)
                .HasMaxLength(50)
                .HasColumnName("NSolicitud");
            entity.Property(e => e.Nunidades)
                .HasMaxLength(50)
                .HasColumnName("NUnidades");
            entity.Property(e => e.NunidadesPeriodo1)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo1");
            entity.Property(e => e.NunidadesPeriodo2)
                .HasMaxLength(50)
                .HasColumnName("NUnidadesPeriodo2");
            entity.Property(e => e.TipoImpositivo).HasMaxLength(50);
            entity.Property(e => e.TipoValoracion).HasMaxLength(50);
            entity.Property(e => e.Zona).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977701020DetC220>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_701020_DET_C2_20");

            entity.Property(e => e.CodDesPers).HasMaxLength(50);
            entity.Property(e => e.CodigoAplicado).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977702001>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702001");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.FechaFin).HasMaxLength(50);
            entity.Property(e => e.FechaIni).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702001DetC4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702001_DET_C4");

            entity.Property(e => e.AmbitoLlamada)
                .HasMaxLength(50)
                .HasColumnName("AmbitoLLamada");
            entity.Property(e => e.Detalle).HasMaxLength(50);
            entity.Property(e => e.DuracionLlamada)
                .HasMaxLength(50)
                .HasColumnName("DuracionLLamada");
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteValor).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NumeroLlamadas)
                .HasMaxLength(50)
                .HasColumnName("NumeroLLamadas");
        });

        modelBuilder.Entity<TrgTel977702001DetC47>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702001_DET_C4_7");

            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPer).HasMaxLength(50);
            entity.Property(e => e.Duracion).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nllamadas).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702002>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702002");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.FechaFin).HasMaxLength(50);
            entity.Property(e => e.FechaIni).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702002DetC4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702002_DET_C4");

            entity.Property(e => e.AmbitoLlamada)
                .HasMaxLength(50)
                .HasColumnName("AmbitoLLamada");
            entity.Property(e => e.Detalle).HasMaxLength(50);
            entity.Property(e => e.DuracionLlamada)
                .HasMaxLength(50)
                .HasColumnName("DuracionLLamada");
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteValor).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NumeroLlamadas)
                .HasMaxLength(50)
                .HasColumnName("NumeroLLamadas");
            entity.Property(e => e.NumeroLocuciones).HasMaxLength(50);
            entity.Property(e => e.Pdestino)
                .HasMaxLength(50)
                .HasColumnName("PDestino");
            entity.Property(e => e.Porigen).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702002DetC410>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702002_DET_C4_10");

            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPer).HasMaxLength(50);
            entity.Property(e => e.Duracion).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nllamadas).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702003>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702003");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702003DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702003_DET_C2");

            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio).HasMaxLength(50);
            entity.Property(e => e.ImporteInter).HasMaxLength(50);
            entity.Property(e => e.ImporteNac).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nred)
                .HasMaxLength(50)
                .HasColumnName("NRed");
            entity.Property(e => e.Ubtcor)
                .HasMaxLength(50)
                .HasColumnName("UBTCor");
            entity.Property(e => e.Ubttar)
                .HasMaxLength(50)
                .HasColumnName("UBTTar");
        });

        modelBuilder.Entity<TrgTel977702003DetC28>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702003_DET_C2_8");

            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPer).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977702004>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702004");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.FechaFin).HasMaxLength(50);
            entity.Property(e => e.FechaIni).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702004DetC4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702004_DET_C4");

            entity.Property(e => e.CodVariable).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FormatVariable).HasMaxLength(50);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteValor).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nunidades)
                .HasMaxLength(50)
                .HasColumnName("NUnidades");
        });

        modelBuilder.Entity<TrgTel977702004DetC46>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702004_DET_C4_6");

            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPer).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977702009>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702009");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702009DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702009_DET_C2");

            entity.Property(e => e.Duracion).HasMaxLength(50);
            entity.Property(e => e.EstadoLlamada).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteValor).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nllamadas)
                .HasMaxLength(50)
                .HasColumnName("NLlamadas");
        });

        modelBuilder.Entity<TrgTel977702010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702010 ");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702010DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702010_DET_C2");

            entity.Property(e => e.AmbitoLlamada)
                .HasMaxLength(50)
                .HasColumnName("AmbitoLLamada");
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPer).HasMaxLength(50);
            entity.Property(e => e.Destino).HasMaxLength(50);
            entity.Property(e => e.DuracionLlamada)
                .HasMaxLength(50)
                .HasColumnName("DuracionLLamada");
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fllamada)
                .HasMaxLength(50)
                .HasColumnName("FLlamada");
            entity.Property(e => e.HoraInicio).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteValor).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nsolicitado)
                .HasMaxLength(50)
                .HasColumnName("NSolicitado");
            entity.Property(e => e.NumeroLlamado)
                .HasMaxLength(50)
                .HasColumnName("NumeroLLamado");
            entity.Property(e => e.OperadorProveedor).HasMaxLength(50);
            entity.Property(e => e.Tarifa).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702015>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702015");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.SubTipoTrafico).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702015DetC3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702015_DET_C3");

            entity.Property(e => e.AmbitoLlamada)
                .HasMaxLength(50)
                .HasColumnName("AmbitoLLamada");
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPer).HasMaxLength(50);
            entity.Property(e => e.Destino).HasMaxLength(50);
            entity.Property(e => e.Duracion).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasMaxLength(50);
            entity.Property(e => e.Hora).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteValor).HasMaxLength(50);
            entity.Property(e => e.Locuciones).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nrecibo)
                .HasMaxLength(50)
                .HasColumnName("NRecibo");
            entity.Property(e => e.NtelPer)
                .HasMaxLength(50)
                .HasColumnName("NTelPer");
            entity.Property(e => e.NumeroLlamado)
                .HasMaxLength(50)
                .HasColumnName("NumeroLLamado");
            entity.Property(e => e.OperadorProveedor).HasMaxLength(50);
            entity.Property(e => e.Origen).HasMaxLength(50);
            entity.Property(e => e.Servicio).HasMaxLength(50);
            entity.Property(e => e.Tarifa).HasMaxLength(50);
            entity.Property(e => e.TipoVariable).HasMaxLength(50);
            entity.Property(e => e.Unidades).HasMaxLength(50);
            entity.Property(e => e.UnidadesVolumen).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702017>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702017");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodDescuento).HasMaxLength(50);
            entity.Property(e => e.CodDescuentoPers).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodTextFac).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.Duracion).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.FechaEvento).HasMaxLength(50);
            entity.Property(e => e.HoraEvento).HasMaxLength(50);
            entity.Property(e => e.ImpDescuento).HasMaxLength(50);
            entity.Property(e => e.ImpEstandar).HasMaxLength(50);
            entity.Property(e => e.ImpFac).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NMulti)
                .HasMaxLength(50)
                .HasColumnName("nMulti");
            entity.Property(e => e.NParticipantes)
                .HasMaxLength(50)
                .HasColumnName("nParticipantes");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.ReducTiempo).HasMaxLength(50);
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.SumReservas).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702017DetC12>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702017_DET_C12");

            entity.Property(e => e.CodTipoAcc).HasMaxLength(50);
            entity.Property(e => e.Duracion).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hora).HasMaxLength(50);
            entity.Property(e => e.ImpAcceso).HasMaxLength(50);
            entity.Property(e => e.ImpDisponibilidad).HasMaxLength(50);
            entity.Property(e => e.ImpOcupacion).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Ncanales)
                .HasMaxLength(50)
                .HasColumnName("NCanales");
            entity.Property(e => e.PartReserva).HasMaxLength(50);
            entity.Property(e => e.Tarifa).HasMaxLength(50);
            entity.Property(e => e.TelParticipante).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702020>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702020");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702020DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702020_DET_C2");

            entity.Property(e => e.AmbitoLlamada)
                .HasMaxLength(50)
                .HasColumnName("AmbitoLLamada");
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPer).HasMaxLength(50);
            entity.Property(e => e.Destino).HasMaxLength(50);
            entity.Property(e => e.DuracionLlamada)
                .HasMaxLength(50)
                .HasColumnName("DuracionLLamada");
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio).HasMaxLength(50);
            entity.Property(e => e.HoraInicio).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.ImporteValor).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nencaminamiento)
                .HasMaxLength(50)
                .HasColumnName("NEncaminamiento");
            entity.Property(e => e.Ntelefono)
                .HasMaxLength(50)
                .HasColumnName("NTelefono");
            entity.Property(e => e.NumeroUnidades).HasMaxLength(50);
            entity.Property(e => e.Origen).HasMaxLength(50);
            entity.Property(e => e.Razon).HasMaxLength(50);
            entity.Property(e => e.Tarifa).HasMaxLength(50);
            entity.Property(e => e.TipoDestino).HasMaxLength(50);
            entity.Property(e => e.TipoOrigen).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702025>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702025");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702025DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702025_DET_C2");

            entity.Property(e => e.Duracion).HasMaxLength(50);
            entity.Property(e => e.EstadoActual).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fcobro)
                .HasMaxLength(50)
                .HasColumnName("FCobro");
            entity.Property(e => e.Festado).HasMaxLength(50);
            entity.Property(e => e.Ffactura)
                .HasMaxLength(50)
                .HasColumnName("FFactura");
            entity.Property(e => e.Finicio).HasMaxLength(50);
            entity.Property(e => e.Fretribucion)
                .HasMaxLength(50)
                .HasColumnName("FRetribucion");
            entity.Property(e => e.Hinicio)
                .HasMaxLength(50)
                .HasColumnName("HInicio");
            entity.Property(e => e.Importe).HasMaxLength(50);
            entity.Property(e => e.NEstados)
                .HasMaxLength(50)
                .HasColumnName("nEstados");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Nivel).HasMaxLength(50);
            entity.Property(e => e.Nllamante)
                .HasMaxLength(50)
                .HasColumnName("nllamante");
            entity.Property(e => e.OperadorOrigen).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702025DetC215>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702025_DET_C2_15");

            entity.Property(e => e.Estado).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Festado).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977702030>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702030");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NCanal)
                .HasMaxLength(50)
                .HasColumnName("nCanal");
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NRedIberPac)
                .HasMaxLength(50)
                .HasColumnName("nRedIberPac");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RedNriOri).HasMaxLength(50);
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702030DetC5>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702030_DET_C5");

            entity.Property(e => e.Cantidad).HasMaxLength(50);
            entity.Property(e => e.CodDescuento).HasMaxLength(50);
            entity.Property(e => e.CodDescuentoPer).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fllamada).HasMaxLength(50);
            entity.Property(e => e.Importe).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Tarifa).HasMaxLength(50);
            entity.Property(e => e.TipoInformacion).HasMaxLength(50);
            entity.Property(e => e.UnidadesTarificacion).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702032>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702032");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NCanal)
                .HasMaxLength(50)
                .HasColumnName("nCanal");
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nri)
                .HasMaxLength(50)
                .HasColumnName("nri");
            entity.Property(e => e.RedNriOri).HasMaxLength(50);
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702032DetC5>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702032_DET_C5");

            entity.Property(e => e.CodigoDesPers).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fllamada)
                .HasMaxLength(50)
                .HasColumnName("FLlamada");
            entity.Property(e => e.HoraLlamada).HasMaxLength(50);
            entity.Property(e => e.ImpBrutoLlamada).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nllamado)
                .HasMaxLength(50)
                .HasColumnName("NLlamado");
            entity.Property(e => e.Nridestino)
                .HasMaxLength(50)
                .HasColumnName("NRIDestino");
            entity.Property(e => e.RedDestino).HasMaxLength(50);
            entity.Property(e => e.Tarifa).HasMaxLength(50);
            entity.Property(e => e.TiempoMin).HasMaxLength(50);
            entity.Property(e => e.TipoAcceso).HasMaxLength(50);
            entity.Property(e => e.TipoLlamada).HasMaxLength(50);
            entity.Property(e => e.TipoTiempo).HasMaxLength(50);
            entity.Property(e => e.Ubtllamada)
                .HasMaxLength(50)
                .HasColumnName("UBTLlamada");
            entity.Property(e => e.VolumenSeg).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702034>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702034");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.IndentOri).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoIndentOri).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702034DetC4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702034_DET_C4");

            entity.Property(e => e.Ambito).HasMaxLength(50);
            entity.Property(e => e.CodigoDesPers).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.Duracion).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fllamada)
                .HasMaxLength(50)
                .HasColumnName("FLlamada");
            entity.Property(e => e.HoraLlamada).HasMaxLength(50);
            entity.Property(e => e.Idestino)
                .HasMaxLength(50)
                .HasColumnName("IDestino");
            entity.Property(e => e.ImpBrutoLlamada).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.LlamadaN).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Tarifa).HasMaxLength(50);
            entity.Property(e => e.TipoIdentif).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702036>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702036");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702036DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702036_DET_C2");

            entity.Property(e => e.CodigoDesPers).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.Destino).HasMaxLength(50);
            entity.Property(e => e.Duracion).HasMaxLength(50);
            entity.Property(e => e.Evento).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaFin).HasMaxLength(50);
            entity.Property(e => e.FechaInicio).HasMaxLength(50);
            entity.Property(e => e.HoraFin).HasMaxLength(50);
            entity.Property(e => e.HoraInicio).HasMaxLength(50);
            entity.Property(e => e.ImpSobretasa).HasMaxLength(50);
            entity.Property(e => e.ImpTasa).HasMaxLength(50);
            entity.Property(e => e.ImpTotal).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.MedioUtilizado).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nsolicitud)
                .HasMaxLength(50)
                .HasColumnName("NSolicitud");
            entity.Property(e => e.Origen).HasMaxLength(50);
            entity.Property(e => e.Sobretasa).HasMaxLength(50);
            entity.Property(e => e.Tasa).HasMaxLength(50);
            entity.Property(e => e.TipoConvSobretasa).HasMaxLength(50);
            entity.Property(e => e.TipoConvTasa).HasMaxLength(50);
            entity.Property(e => e.TipoMonedaSobretasa).HasMaxLength(50);
            entity.Property(e => e.TipoMonedaTasa).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702038>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702038");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702038DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702038_DET_C2");

            entity.Property(e => e.Ambito).HasMaxLength(50);
            entity.Property(e => e.AnchoAdelante).HasMaxLength(50);
            entity.Property(e => e.AnchoAtras).HasMaxLength(50);
            entity.Property(e => e.CodigoDesPers).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.Creditos).HasMaxLength(50);
            entity.Property(e => e.Duracion).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaFin).HasMaxLength(50);
            entity.Property(e => e.FechaInicio).HasMaxLength(50);
            entity.Property(e => e.HoraFin).HasMaxLength(50);
            entity.Property(e => e.HoraInicio).HasMaxLength(50);
            entity.Property(e => e.Identificador).HasMaxLength(50);
            entity.Property(e => e.ImpConex).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Tarifa).HasMaxLength(50);
            entity.Property(e => e.Usuario).HasMaxLength(50);
            entity.Property(e => e.UsuarioDestino).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702040>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702040");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Informativo1).HasMaxLength(50);
            entity.Property(e => e.Informativo2).HasMaxLength(50);
            entity.Property(e => e.Informativo3).HasMaxLength(50);
            entity.Property(e => e.Informativo4).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.SubTipoTrafico).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977702040DetC7>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_702040_DET_C7");

            entity.Property(e => e.CodigoDesPers).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoVariable).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasMaxLength(45);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasMaxLength(50);
            entity.Property(e => e.Formato).HasMaxLength(50);
            entity.Property(e => e.Hora).HasMaxLength(50);
            entity.Property(e => e.ImpEstandar).HasMaxLength(50);
            entity.Property(e => e.ImpValor).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nunidades)
                .HasMaxLength(50)
                .HasColumnName("NUnidades");
        });

        modelBuilder.Entity<TrgTel977703010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_703010");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977703010DetC1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_703010_DET_C1");

            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPers).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinPeriodo).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.ImporteSujetoDescuento).HasMaxLength(50);
            entity.Property(e => e.InicioPeriodo).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977703020>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_703020");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodConcentracion).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.FinPeriodo).HasMaxLength(50);
            entity.Property(e => e.IniPeriodo).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977703020DetC4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_703020_DET_C4");

            entity.Property(e => e.Dtoporcen)
                .HasMaxLength(50)
                .HasColumnName("DTOPorcen");
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpSujetoDescuento).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nadmin)
                .HasMaxLength(50)
                .HasColumnName("NAdmin");
            entity.Property(e => e.TipoConcentracion).HasMaxLength(50);
            entity.Property(e => e.Tramo).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977704010>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_704010");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977704010DetC1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_704010_DET_C1");

            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImporteConcepto).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977901000>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_901000");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nposiciones)
                .HasMaxLength(50)
                .HasColumnName("NPosiciones");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977901000DetC1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_901000_DET_C1");

            entity.Property(e => e.CodigoEquipo).HasMaxLength(50);
            entity.Property(e => e.CodigoExterno).HasMaxLength(50);
            entity.Property(e => e.CodigoInterno).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasMaxLength(180);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
        });

        modelBuilder.Entity<TrgTel977902000>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_902000");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977902000DetC1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_902000_DET_C1");

            entity.Property(e => e.CodigoUbicacion).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Texto).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977903000>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_903000");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro2).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977903000DetC2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_903000_DET_C2");

            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nbloque)
                .HasMaxLength(50)
                .HasColumnName("NBloque");
            entity.Property(e => e.NbloquePadre)
                .HasMaxLength(50)
                .HasColumnName("NBloquePadre");
            entity.Property(e => e.RepeticionesConcepto).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977903000DetC23>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TEL_977_903000_DET_C2_3");

            entity.Property(e => e.CodExTabAux).HasMaxLength(50);
            entity.Property(e => e.DescCampo).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FormatoCampo).HasMaxLength(50);
            entity.Property(e => e.IndCampo).HasMaxLength(50);
            entity.Property(e => e.LogitudCampo).HasMaxLength(50);
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.PosicionCampo).HasMaxLength(50);
            entity.Property(e => e.TipoCampo).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTel977TipoTrafico>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_TEL_977_TipoTrafico");

            entity.Property(e => e.AmbitoLlamada)
                .HasMaxLength(50)
                .HasColumnName("AmbitoLLamada");
            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .HasColumnName("anio");
            entity.Property(e => e.Fllamada)
                .HasMaxLength(50)
                .HasColumnName("FLlamada");
            entity.Property(e => e.ImporteEstandar).HasMaxLength(50);
            entity.Property(e => e.Tarifa).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgTeleTipo2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TELE_TIPO2");

            entity.Property(e => e.Aplicacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("APLICACION");
            entity.Property(e => e.BaseImponible).HasColumnName("BASE_IMPONIBLE");
            entity.Property(e => e.CifCliente)
                .HasMaxLength(9)
                .HasColumnName("CIF_CLIENTE");
            entity.Property(e => e.CifProveedor)
                .HasMaxLength(9)
                .HasColumnName("CIF_PROVEEDOR");
            entity.Property(e => e.Consumos).HasColumnName("CONSUMOS");
            entity.Property(e => e.Cuotas).HasColumnName("CUOTAS");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Descuentos).HasColumnName("DESCUENTOS");
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("FACTURA_INTERNA");
            entity.Property(e => e.FechaFactura)
                .HasMaxLength(50)
                .HasColumnName("FECHA_FACTURA");
            entity.Property(e => e.IdAgrupacion)
                .HasMaxLength(50)
                .HasColumnName("ID_AGRUPACION");
            entity.Property(e => e.IdFactura)
                .HasMaxLength(50)
                .HasColumnName("ID_FACTURA");
            entity.Property(e => e.IdTelefono)
                .HasMaxLength(50)
                .HasColumnName("ID_TELEFONO");
            entity.Property(e => e.Impuestos).HasColumnName("IMPUESTOS");
            entity.Property(e => e.Nivel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NIVEL");
            entity.Property(e => e.Operador)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OPERADOR");
            entity.Property(e => e.Otros).HasColumnName("OTROS");
            entity.Property(e => e.Porcentaje)
                .HasMaxLength(50)
                .HasColumnName("PORCENTAJE");
            entity.Property(e => e.TipoImpuesto)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("TIPO_IMPUESTO");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
        });

        modelBuilder.Entity<TrgTeleTipo3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_TELE_TIPO3");

            entity.Property(e => e.Aplicacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("APLICACION");
            entity.Property(e => e.BaseImponible).HasColumnName("BASE_IMPONIBLE");
            entity.Property(e => e.CifCliente)
                .HasMaxLength(9)
                .HasColumnName("CIF_CLIENTE");
            entity.Property(e => e.CifProveedor)
                .HasMaxLength(9)
                .HasColumnName("CIF_PROVEEDOR");
            entity.Property(e => e.Consumos).HasColumnName("CONSUMOS");
            entity.Property(e => e.Cuotas).HasColumnName("CUOTAS");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Descuentos).HasColumnName("DESCUENTOS");
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("FACTURA_INTERNA");
            entity.Property(e => e.FechaFactura)
                .HasMaxLength(50)
                .HasColumnName("FECHA_FACTURA");
            entity.Property(e => e.IdAgrupacion)
                .HasMaxLength(50)
                .HasColumnName("ID_AGRUPACION");
            entity.Property(e => e.IdFactura)
                .HasMaxLength(50)
                .HasColumnName("ID_FACTURA");
            entity.Property(e => e.IdTelefono)
                .HasMaxLength(50)
                .HasColumnName("ID_TELEFONO");
            entity.Property(e => e.Impuestos).HasColumnName("IMPUESTOS");
            entity.Property(e => e.Nivel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NIVEL");
            entity.Property(e => e.Operador)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OPERADOR");
            entity.Property(e => e.Otros).HasColumnName("OTROS");
            entity.Property(e => e.Porcentaje)
                .HasMaxLength(50)
                .HasColumnName("PORCENTAJE");
            entity.Property(e => e.TipoImpuesto)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("TIPO_IMPUESTO");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
        });

        modelBuilder.Entity<TrgTramosConsumo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_Tramos_Consumo");

            entity.Property(e => e.DescTramo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descTramo");
            entity.Property(e => e.IdTramo).HasColumnName("idTramo");
            entity.Property(e => e.Inferior).HasColumnName("inferior");
            entity.Property(e => e.Superior).HasColumnName("superior");
        });

        modelBuilder.Entity<TrgVdfCargosAjustes>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_VDF_CargosAjustes");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.Idregistro)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDREGISTRO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.Telef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF");
            entity.Property(e => e.TelefOld)
                .HasMaxLength(50)
                .HasColumnName("TELEF_OLD");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
        });

        modelBuilder.Entity<TrgVdfCliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_VDF_Cliente");

            entity.Property(e => e.AtencionDe)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ATENCION_DE");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Dir1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DIR1");
            entity.Property(e => e.Dir2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DIR2");
            entity.Property(e => e.Dir3)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DIR3");
            entity.Property(e => e.Dir4)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DIR4");
            entity.Property(e => e.Dir5)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DIR5");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.Idregistro)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDREGISTRO");
            entity.Property(e => e.NombreEmp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_EMP");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
        });

        modelBuilder.Entity<TrgVdfCompras>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_VDF_Compras");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Comercio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMERCIO");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.FechaHora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA_HORA");
            entity.Property(e => e.Idregistro)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDREGISTRO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCTO");
            entity.Property(e => e.Telef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF");
            entity.Property(e => e.TelefOld)
                .HasMaxLength(50)
                .HasColumnName("TELEF_OLD");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
        });

        modelBuilder.Entity<TrgVdfCuenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_VDF_Cuenta");

            entity.Property(e => e.AbonoPend)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ABONO_PEND");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.Idregistro)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDREGISTRO");
            entity.Property(e => e.SaldoPend)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SALDO_PEND");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
            entity.Property(e => e.TotalFactura)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTAL_FACTURA");
            entity.Property(e => e.TotalPagar)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTAL_PAGAR");
        });

        modelBuilder.Entity<TrgVdfDescuentos>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TRG_VDF_Descuentos");

            entity.Property(e => e.Idregistro).HasColumnName("IDREGISTRO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUENTA");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.FechaFin)
                .HasMaxLength(50)
                .HasColumnName("FECHA_FIN");
            entity.Property(e => e.FechaInicio)
                .HasMaxLength(50)
                .HasColumnName("FECHA_INICIO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.Porcent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PORCENT");
            entity.Property(e => e.Telef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF");
            entity.Property(e => e.TelefOld)
                .HasMaxLength(50)
                .HasColumnName("TELEF_OLD");
            entity.Property(e => e.TipoDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_DESC");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
        });

        modelBuilder.Entity<TrgVdfDetalleCuotas>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TRG_VDF_DetalleCuotas");

            entity.HasIndex(e => new { e.Tiporeg, e.FactNo }, "IX_TRG_VDF_DetalleCuotas_procesos").HasFillFactor(80);

            entity.Property(e => e.Idregistro).HasColumnName("IDREGISTRO");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.DescripCuota)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DESCRIP_CUOTA");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.FechaFin)
                .HasMaxLength(50)
                .HasColumnName("FECHA_FIN");
            entity.Property(e => e.FechaInicio)
                .HasMaxLength(50)
                .HasColumnName("FECHA_INICIO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.Packsg).HasColumnName("PACKSG");
            entity.Property(e => e.Telef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF");
            entity.Property(e => e.TelefOld)
                .HasMaxLength(50)
                .HasColumnName("TELEF_OLD");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
        });

        modelBuilder.Entity<TrgVdfDetalleOtrasCuotas>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_VDF_DetalleOtrasCuotas");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.DescripCuota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIP_CUOTA");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.Idregistro)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDREGISTRO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.Porcentaje)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PORCENTAJE");
            entity.Property(e => e.Telef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF");
            entity.Property(e => e.TelefOld)
                .HasMaxLength(50)
                .HasColumnName("TELEF_OLD");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
            entity.Property(e => e.Unidades).HasColumnName("UNIDADES");
        });

        modelBuilder.Entity<TrgVdfDetalleTelefono>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TRG_VDF_DetalleTelefono");

            entity.HasIndex(e => new { e.FactNo, e.TelefExt, e.Importe }, "IX_TRG_VDF_DetalleTelefono_lineas").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciclo, e.ImporteNeto }, "IX_TRG_VDF_DetalleTelefono_procesos").HasFillFactor(80);

            entity.HasIndex(e => new { e.Ciclo, e.FactNo }, "IX_TRG_VDF_DetalleTelefono_procesos2").HasFillFactor(80);

            entity.Property(e => e.Idregistro).HasColumnName("IDREGISTRO");
            entity.Property(e => e.Canal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANAL");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
            entity.Property(e => e.Destino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESTINO");
            entity.Property(e => e.DuracSes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURAC_SES");
            entity.Property(e => e.Duracion)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DURACION");
            entity.Property(e => e.ExcedeLimiteDuracion).HasColumnName("EXCEDE_LIMITE_DURACION");
            entity.Property(e => e.ExtOrigen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXT_ORIGEN");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.FechaHora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA_HORA");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE_NETO");
            entity.Property(e => e.NoOrigen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NO_ORIGEN");
            entity.Property(e => e.NoRecep)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NO_RECEP");
            entity.Property(e => e.Packsg).HasColumnName("PACKSG");
            entity.Property(e => e.Pasos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASOS");
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TARIFA");
            entity.Property(e => e.TelefExt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF_EXT");
            entity.Property(e => e.TelefExtOld)
                .HasMaxLength(50)
                .HasColumnName("TELEF_EXT_OLD");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoFact)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_FACT");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
            entity.Property(e => e.Volumen)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VOLUMEN");
        });

        modelBuilder.Entity<TrgVdfFactura>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TRG_VDF_Factura");

            entity.Property(e => e.Idregistro).HasColumnName("IDREGISTRO");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.CuentaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUENTA_NO");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.FechaEmision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA_EMISION");
            entity.Property(e => e.FechaFin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA_FIN");
            entity.Property(e => e.FechaInicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA_INICIO");
            entity.Property(e => e.LugarEmision)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("LUGAR_EMISION");
            entity.Property(e => e.NifCif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIF_CIF");
            entity.Property(e => e.NumLineas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUM_LINEAS");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
            entity.Property(e => e.Titular)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TITULAR");
        });

        modelBuilder.Entity<TrgVdfFinanciacion>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TRG_VDF_Financiacion");

            entity.Property(e => e.Idregistro).HasColumnName("IDREGISTRO");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(8)
                .HasColumnName("CICLO");
            entity.Property(e => e.Conciliacion)
                .HasMaxLength(10)
                .HasColumnName("CONCILIACION");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.ImporteConciliacion)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE_CONCILIACION");
            entity.Property(e => e.Telef)
                .HasMaxLength(50)
                .HasColumnName("TELEF");
            entity.Property(e => e.TelefOld)
                .HasMaxLength(50)
                .HasColumnName("TELEF_OLD");
            entity.Property(e => e.TipoConcep)
                .HasMaxLength(100)
                .HasColumnName("TIPO_CONCEP");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(8)
                .HasColumnName("TIPOREG");
        });

        modelBuilder.Entity<TrgVdfPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_VDF_Pago");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.CtaIngreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CTA_INGRESO");
            entity.Property(e => e.EntBancaria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENT_BANCARIA");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.FechaVto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA_VTO");
            entity.Property(e => e.FormaPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FORMA_PAGO");
            entity.Property(e => e.Idregistro)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDREGISTRO");
            entity.Property(e => e.NoCuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NO_CUENTA");
            entity.Property(e => e.NoTarjeta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NO_TARJETA");
            entity.Property(e => e.Refer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFER");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
        });

        modelBuilder.Entity<TrgVdfPostVenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_VDF_PostVenta");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.CosteServ)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COSTE_SERV");
            entity.Property(e => e.DescripMat)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DESCRIP_MAT");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.Fecha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA");
            entity.Property(e => e.Idregistro)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDREGISTRO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.Servicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICIO");
            entity.Property(e => e.Telef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF");
            entity.Property(e => e.TelefOld)
                .HasMaxLength(50)
                .HasColumnName("TELEF_OLD");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
        });

        modelBuilder.Entity<TrgVdfResumenConcFact>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TRG_VDF_ResumenConcFact");

            entity.Property(e => e.Idregistro).HasColumnName("IDREGISTRO");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE_NETO");
            entity.Property(e => e.LblGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LBL_GRUPO");
            entity.Property(e => e.LblTipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LBL_TIPO");
            entity.Property(e => e.MinutosKb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MINUTOS_KB");
            entity.Property(e => e.NLlamadas).HasColumnName("N_LLAMADAS");
            entity.Property(e => e.NumServ)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUM_SERV");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
        });

        modelBuilder.Entity<TrgVdfResumenFactura>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TRG_VDF_ResumenFactura");

            entity.Property(e => e.Idregistro).HasColumnName("IDREGISTRO");
            entity.Property(e => e.BaseImp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BASE_IMP");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.Impuesto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPUESTO");
            entity.Property(e => e.Porcentaje)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PORCENTAJE");
            entity.Property(e => e.TipoImp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_IMP");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<TrgVdfResumenTelefono>(entity =>
        {
            entity.HasKey(e => e.Idregistro);

            entity.ToTable("TRG_VDF_ResumenTelefono");

            entity.HasIndex(e => e.Ciclo, "IX_TRG_VDF_ResumenTelefono_procesos").HasFillFactor(80);

            entity.Property(e => e.Idregistro).HasColumnName("IDREGISTRO");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUENTA");
            entity.Property(e => e.Cuotas)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CUOTAS");
            entity.Property(e => e.Descuento)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IMPORTE_NETO");
            entity.Property(e => e.PPreciosDatos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P_PRECIOS_DATOS");
            entity.Property(e => e.PPreciosVoz)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P_PRECIOS_VOZ");
            entity.Property(e => e.Telef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF");
            entity.Property(e => e.TelefOld)
                .HasMaxLength(50)
                .HasColumnName("TELEF_OLD");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Tiporeg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOREG");
        });

        modelBuilder.Entity<TrgVdfResumenTelf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VDF_RESUMEN_TELF");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Consumo)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CONSUMO");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUENTA");
            entity.Property(e => e.CuentaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUENTA_NO");
            entity.Property(e => e.CuotaMes)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CUOTA_MES");
            entity.Property(e => e.Descuentos)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DESCUENTOS");
            entity.Property(e => e.MsintCant).HasColumnName("MSINT_CANT");
            entity.Property(e => e.MsintEuros)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MSINT_EUROS");
            entity.Property(e => e.MsmnvCant).HasColumnName("MSMNV_CANT");
            entity.Property(e => e.MsmnvEuros)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MSMNV_EUROS");
            entity.Property(e => e.MsmvCant).HasColumnName("MSMV_CANT");
            entity.Property(e => e.MsmvEuros)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MSMV_EUROS");
            entity.Property(e => e.OtrasCuot)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OTRAS_CUOT");
            entity.Property(e => e.OtrosAb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OTROS_AB");
            entity.Property(e => e.OtrosCar)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OTROS_CAR");
            entity.Property(e => e.PPrecios)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P_PRECIOS");
            entity.Property(e => e.TelefExt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF_EXT");
            entity.Property(e => e.Titular)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TITULAR");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.TotalCantidad).HasColumnName("TOTAL_CANTIDAD");
            entity.Property(e => e.TotalEuros)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTAL_EUROS");
        });

        modelBuilder.Entity<TrgVdfnAnexo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_VDFN_ANEXO");

            entity.Property(e => e.Aplicacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CifEmpresa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cif_Empresa");
            entity.Property(e => e.Factura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Porcentaje)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoImpuesto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Impuesto");
        });

        modelBuilder.Entity<TrgVdfnDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_VDFN_DETALLE");

            entity.Property(e => e.Canal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANAL");
            entity.Property(e => e.Cantidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Destino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESTINO");
            entity.Property(e => e.DuracSesion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURAC. SESION");
            entity.Property(e => e.Duracion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURACION");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXTENSION");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.FechaHora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA_HORA");
            entity.Property(e => e.Importe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE");
            entity.Property(e => e.ImporteNeto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE_NETO");
            entity.Property(e => e.LlamadaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LLAMADA_NO");
            entity.Property(e => e.NLlamado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_LLAMADO");
            entity.Property(e => e.Pasos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASOS");
            entity.Property(e => e.Receptor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RECEPTOR");
            entity.Property(e => e.Servicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICIO");
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TARIFA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoFact)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_FACT");
            entity.Property(e => e.Volumen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VOLUMEN");
        });

        modelBuilder.Entity<TrgVdfnResumen>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TRG_VDFN_RESUMEN");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Consumo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONSUMO");
            entity.Property(e => e.CuotaMensual)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUOTA_MENSUAL");
            entity.Property(e => e.Descuentos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCUENTOS");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.OtrasCuotas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTRAS_CUOTAS");
            entity.Property(e => e.OtrosAbonos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTROS_ABONOS");
            entity.Property(e => e.OtrosCargos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTROS_CARGOS");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Total)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<TrgVozDatosFactura>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VOZ_DATOS_FACTURA");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.DescripcionCargo).HasMaxLength(50);
            entity.Property(e => e.Empresa)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.FechaEmision).HasMaxLength(50);
            entity.Property(e => e.FechaPuestaCobro).HasMaxLength(50);
            entity.Property(e => e.Mes)
                .HasMaxLength(30)
                .HasColumnName("mes");
            entity.Property(e => e.Mes2).HasColumnName("mes2");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
            entity.Property(e => e.TipoFactura).HasMaxLength(1);
        });

        modelBuilder.Entity<TrgVwCuotasDatosVoz>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_CUOTAS_DATOS_VOZ");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodDesApli).HasMaxLength(50);
            entity.Property(e => e.CodDesPeriodo1).HasMaxLength(50);
            entity.Property(e => e.CodDesPeriodo2).HasMaxLength(50);
            entity.Property(e => e.CodDesPers).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodPaquete).HasMaxLength(50);
            entity.Property(e => e.CodProdConcepFact).HasMaxLength(50);
            entity.Property(e => e.CodProdPers).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.ImporteDescuento).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.ImporteDistancia).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.ImporteEstandar).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.ImporteTotal).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.ImporteUnitario).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
            entity.Property(e => e.Nunidades)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("NUnidades");
            entity.Property(e => e.NunidadesPeriodo1)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("NUnidadesPeriodo1");
            entity.Property(e => e.NunidadesPeriodo2)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("NUnidadesPeriodo2");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.TipoImpositivo).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoValoracion).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgVwCuotasDatosVoz2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_CUOTAS_DATOS_VOZ_2");

            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodDesApli)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CodDesPeriodo1).HasMaxLength(50);
            entity.Property(e => e.CodDesPeriodo2).HasMaxLength(50);
            entity.Property(e => e.CodDesPers)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodPaquete).HasMaxLength(50);
            entity.Property(e => e.CodProdConcepFact).HasMaxLength(50);
            entity.Property(e => e.CodProdPers).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoConcepto).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.FacturaInterna)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.ImporteDescuento)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ImporteDistancia).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.ImporteEstandar).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.ImporteTotal).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.ImporteUnitario).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.NivelImpositivo).HasMaxLength(50);
            entity.Property(e => e.Nunidades)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("NUnidades");
            entity.Property(e => e.NunidadesPeriodo1)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("NUnidadesPeriodo1");
            entity.Property(e => e.NunidadesPeriodo2)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("NUnidadesPeriodo2");
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.TipoImpositivo).HasColumnType("numeric(12, 2)");
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoValoracion).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgVwCuotasMoviles>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_CUOTAS_MOVILES");

            entity.Property(e => e.CodigoCuota).HasMaxLength(50);
            entity.Property(e => e.Contador).HasColumnName("contador");
            entity.Property(e => e.DescripcionCuota).HasMaxLength(250);
            entity.Property(e => e.Ffin)
                .HasMaxLength(50)
                .HasColumnName("FFin");
            entity.Property(e => e.Finicio)
                .HasMaxLength(50)
                .HasColumnName("FInicio");
            entity.Property(e => e.IdOperador)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Nextension).HasMaxLength(50);
            entity.Property(e => e.Nfactura)
                .HasMaxLength(50)
                .HasColumnName("NFactura");
            entity.Property(e => e.Ntelefono).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgVwDescuentosMoviles>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_DESCUENTOS_MOVILES");

            entity.Property(e => e.FechFactura).HasMaxLength(50);
            entity.Property(e => e.LibNfactura)
                .HasMaxLength(50)
                .HasColumnName("libNfactura");
            entity.Property(e => e.TotalDescuentos).HasMaxLength(50);
        });

        modelBuilder.Entity<TrgVwDetalleDatosBorrar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_DETALLE_DATOS_BORRAR");

            entity.Property(e => e.AmbitoLlamada)
                .HasMaxLength(50)
                .HasColumnName("AmbitoLLamada");
            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPer).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.Destino).HasMaxLength(50);
            entity.Property(e => e.Duracion).HasMaxLength(50);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Hora).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.ImporteEstandar).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.ImporteValor).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.Locuciones).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nrecibo)
                .HasMaxLength(50)
                .HasColumnName("NRecibo");
            entity.Property(e => e.NtelPer)
                .HasMaxLength(50)
                .HasColumnName("NTelPer");
            entity.Property(e => e.NumeroLlamado)
                .HasMaxLength(50)
                .HasColumnName("NumeroLLamado");
            entity.Property(e => e.OperadorProveedor).HasMaxLength(50);
            entity.Property(e => e.Origen).HasMaxLength(50);
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.Servicio).HasMaxLength(50);
            entity.Property(e => e.SubTipoTrafico).HasMaxLength(50);
            entity.Property(e => e.Tarifa).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
            entity.Property(e => e.TipoVariable).HasMaxLength(50);
            entity.Property(e => e.Unidades).HasColumnType("numeric(12, 0)");
            entity.Property(e => e.UnidadesVolumen).HasColumnType("numeric(12, 0)");
        });

        modelBuilder.Entity<TrgVwDetalleVoz>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_DETALLE_VOZ");

            entity.Property(e => e.AmbitoLlamada)
                .HasMaxLength(50)
                .HasColumnName("AmbitoLLamada");
            entity.Property(e => e.CodAgrupacionDetalle).HasMaxLength(50);
            entity.Property(e => e.CodMulticonexion).HasMaxLength(50);
            entity.Property(e => e.CodigoCliente).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuento).HasMaxLength(50);
            entity.Property(e => e.CodigoDescuentoPer).HasMaxLength(50);
            entity.Property(e => e.CodigoRegistro).HasMaxLength(50);
            entity.Property(e => e.Destino).HasMaxLength(50);
            entity.Property(e => e.Duracion).HasColumnType("numeric(19, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Hora).HasMaxLength(50);
            entity.Property(e => e.ImporteDescuento).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.ImporteEstandar).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.ImporteValor).HasColumnType("numeric(12, 4)");
            entity.Property(e => e.Locuciones).HasMaxLength(50);
            entity.Property(e => e.Longitud).HasMaxLength(50);
            entity.Property(e => e.NComercial1)
                .HasMaxLength(50)
                .HasColumnName("nComercial1");
            entity.Property(e => e.NComercial2)
                .HasMaxLength(50)
                .HasColumnName("nComercial2");
            entity.Property(e => e.NSecuencial)
                .HasMaxLength(50)
                .HasColumnName("nSecuencial");
            entity.Property(e => e.Nfacturainterna)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("NFACTURAINTERNA");
            entity.Property(e => e.Nrecibo)
                .HasMaxLength(50)
                .HasColumnName("NRecibo");
            entity.Property(e => e.NtelPer)
                .HasMaxLength(50)
                .HasColumnName("NTelPer");
            entity.Property(e => e.NumeroLlamado)
                .HasMaxLength(50)
                .HasColumnName("NumeroLLamado");
            entity.Property(e => e.OperadorProveedor).HasMaxLength(50);
            entity.Property(e => e.Origen).HasMaxLength(50);
            entity.Property(e => e.RefAgrupacionFacturable).HasMaxLength(50);
            entity.Property(e => e.Servicio).HasMaxLength(50);
            entity.Property(e => e.SubTipoTrafico).HasMaxLength(50);
            entity.Property(e => e.Tarifa).HasMaxLength(50);
            entity.Property(e => e.TipoOrigen).HasMaxLength(50);
            entity.Property(e => e.TipoServicio).HasMaxLength(50);
            entity.Property(e => e.TipoTrafico).HasMaxLength(50);
            entity.Property(e => e.TipoVariable).HasMaxLength(50);
            entity.Property(e => e.Unidades).HasColumnType("numeric(12, 0)");
            entity.Property(e => e.UnidadesVolumen).HasColumnType("numeric(12, 0)");
        });

        modelBuilder.Entity<TrgVwLineas>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_LINEAS");

            entity.Property(e => e.Ntelefono)
                .HasMaxLength(50)
                .HasColumnName("ntelefono");
            entity.Property(e => e.Operador)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TrgVwMoviTipo1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_MOVI_TIPO1");

            entity.Property(e => e.Aplicacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("APLICACION");
            entity.Property(e => e.BaseImponible)
                .HasMaxLength(50)
                .HasColumnName("BASE_IMPONIBLE");
            entity.Property(e => e.CifCliente)
                .HasMaxLength(50)
                .HasColumnName("CIF_CLIENTE");
            entity.Property(e => e.CifProveedor)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CIF_PROVEEDOR");
            entity.Property(e => e.Consumos)
                .HasMaxLength(50)
                .HasColumnName("CONSUMOS");
            entity.Property(e => e.Cuotas)
                .HasMaxLength(50)
                .HasColumnName("CUOTAS");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Descuentos)
                .HasMaxLength(50)
                .HasColumnName("DESCUENTOS");
            entity.Property(e => e.FechaFactura)
                .HasMaxLength(10)
                .HasColumnName("FECHA_FACTURA");
            entity.Property(e => e.IdAgrupacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ID_AGRUPACION");
            entity.Property(e => e.IdFactura)
                .HasMaxLength(50)
                .HasColumnName("ID_FACTURA");
            entity.Property(e => e.IdTelefono)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ID_TELEFONO");
            entity.Property(e => e.Impuestos)
                .HasMaxLength(50)
                .HasColumnName("IMPUESTOS");
            entity.Property(e => e.Nivel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NIVEL");
            entity.Property(e => e.Operador)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OPERADOR");
            entity.Property(e => e.Otros)
                .HasMaxLength(50)
                .HasColumnName("OTROS");
            entity.Property(e => e.Porcentaje)
                .HasMaxLength(50)
                .HasColumnName("PORCENTAJE");
            entity.Property(e => e.TipoImpuesto)
                .HasMaxLength(50)
                .HasColumnName("TIPO_IMPUESTO");
            entity.Property(e => e.Total)
                .HasMaxLength(50)
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<TrgVwMoviTipo3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_MOVI_TIPO3");

            entity.Property(e => e.Aplicacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("APLICACION");
            entity.Property(e => e.BaseImponible).HasColumnName("BASE_IMPONIBLE");
            entity.Property(e => e.CifCliente)
                .HasMaxLength(50)
                .HasColumnName("CIF_CLIENTE");
            entity.Property(e => e.CifProveedor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CIF_PROVEEDOR");
            entity.Property(e => e.Consumos)
                .HasMaxLength(50)
                .HasColumnName("CONSUMOS");
            entity.Property(e => e.Cuotas).HasColumnName("CUOTAS");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Descuentos).HasColumnName("DESCUENTOS");
            entity.Property(e => e.FechaFactura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FECHA_FACTURA");
            entity.Property(e => e.IdAgrupacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ID_AGRUPACION");
            entity.Property(e => e.IdFactura)
                .HasMaxLength(50)
                .HasColumnName("ID_FACTURA");
            entity.Property(e => e.IdTelefono)
                .HasMaxLength(101)
                .HasColumnName("ID_TELEFONO");
            entity.Property(e => e.Impuestos).HasColumnName("IMPUESTOS");
            entity.Property(e => e.Nivel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NIVEL");
            entity.Property(e => e.Operador)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OPERADOR");
            entity.Property(e => e.Otros).HasColumnName("OTROS");
            entity.Property(e => e.Porcentaje)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PORCENTAJE");
            entity.Property(e => e.TipoImpuesto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_IMPUESTO");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
        });

        modelBuilder.Entity<TrgVwTeleTipo1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_TELE_TIPO1");

            entity.Property(e => e.Aplicacion)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("APLICACION");
            entity.Property(e => e.BaseImponible).HasColumnName("BASE_IMPONIBLE");
            entity.Property(e => e.CifCliente)
                .HasMaxLength(9)
                .HasColumnName("CIF_CLIENTE");
            entity.Property(e => e.CifProveedor)
                .HasMaxLength(9)
                .HasColumnName("CIF_PROVEEDOR");
            entity.Property(e => e.Consumos).HasColumnName("CONSUMOS");
            entity.Property(e => e.Cuotas).HasColumnName("CUOTAS");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Descuentos).HasColumnName("DESCUENTOS");
            entity.Property(e => e.FechaFactura)
                .HasMaxLength(50)
                .HasColumnName("FECHA_FACTURA");
            entity.Property(e => e.IdAgrupacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ID_AGRUPACION");
            entity.Property(e => e.IdFactura)
                .HasMaxLength(50)
                .HasColumnName("ID_FACTURA");
            entity.Property(e => e.IdTelefono)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ID_TELEFONO");
            entity.Property(e => e.Impuestos).HasColumnName("IMPUESTOS");
            entity.Property(e => e.Nivel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NIVEL");
            entity.Property(e => e.Operador)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OPERADOR");
            entity.Property(e => e.Otros).HasColumnName("OTROS");
            entity.Property(e => e.Porcentaje)
                .HasMaxLength(50)
                .HasColumnName("PORCENTAJE");
            entity.Property(e => e.TipoImpuesto)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("TIPO_IMPUESTO");
            entity.Property(e => e.Total)
                .HasMaxLength(50)
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<TrgVwVdfnDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_VDFN_DETALLE");

            entity.Property(e => e.Canal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANAL");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(8, 4)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Destino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESTINO");
            entity.Property(e => e.DuracSesion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURAC_SESION");
            entity.Property(e => e.Duracion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURACION");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXTENSION");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.FechaHora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHA_HORA");
            entity.Property(e => e.Importe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMPORTE");
            entity.Property(e => e.ImporteNeto)
                .HasColumnType("numeric(8, 4)")
                .HasColumnName("IMPORTE_NETO");
            entity.Property(e => e.LlamadaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LLAMADA_NO");
            entity.Property(e => e.NLlamado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_LLAMADO");
            entity.Property(e => e.Pasos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASOS");
            entity.Property(e => e.Receptor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RECEPTOR");
            entity.Property(e => e.Servicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICIO");
            entity.Property(e => e.Tarifa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TARIFA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoFact)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_FACT");
            entity.Property(e => e.Volumen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VOLUMEN");
        });

        modelBuilder.Entity<TrgVwVdfnResumen>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_VDFN_RESUMEN");

            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CICLO");
            entity.Property(e => e.Consumo)
                .HasColumnType("numeric(8, 4)")
                .HasColumnName("CONSUMO");
            entity.Property(e => e.CuotaMensual)
                .HasColumnType("numeric(8, 4)")
                .HasColumnName("CUOTA_MENSUAL");
            entity.Property(e => e.Descuentos)
                .HasColumnType("numeric(8, 4)")
                .HasColumnName("DESCUENTOS");
            entity.Property(e => e.FactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FACT_NO");
            entity.Property(e => e.OtrasCuotas)
                .HasColumnType("numeric(8, 4)")
                .HasColumnName("OTRAS_CUOTAS");
            entity.Property(e => e.OtrosAbonos)
                .HasColumnType("numeric(8, 4)")
                .HasColumnName("OTROS_ABONOS");
            entity.Property(e => e.OtrosCargos)
                .HasColumnType("numeric(8, 4)")
                .HasColumnName("OTROS_CARGOS");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(8, 4)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<TrgVwVdfnTipo1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_VDFN_TIPO1");

            entity.Property(e => e.Aplicacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("APLICACION");
            entity.Property(e => e.BaseImponible).HasColumnName("BASE_IMPONIBLE");
            entity.Property(e => e.CifCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIF_CLIENTE");
            entity.Property(e => e.CifProveedor)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CIF_PROVEEDOR");
            entity.Property(e => e.Consumos).HasColumnName("CONSUMOS");
            entity.Property(e => e.Cuotas).HasColumnName("CUOTAS");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Descuentos).HasColumnName("DESCUENTOS");
            entity.Property(e => e.FechaFactura)
                .HasMaxLength(92)
                .IsUnicode(false)
                .HasColumnName("FECHA_FACTURA");
            entity.Property(e => e.IdAgrupacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ID_AGRUPACION");
            entity.Property(e => e.IdFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID_FACTURA");
            entity.Property(e => e.IdTelefono)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ID_TELEFONO");
            entity.Property(e => e.Impuestos).HasColumnName("IMPUESTOS");
            entity.Property(e => e.Nivel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NIVEL");
            entity.Property(e => e.Operador)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OPERADOR");
            entity.Property(e => e.Otros).HasColumnName("OTROS");
            entity.Property(e => e.Porcentaje)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoImpuesto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Impuesto");
        });

        modelBuilder.Entity<TrgVwVdfnTipo3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TRG_VW_VDFN_TIPO3");

            entity.Property(e => e.Aplicacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("APLICACION");
            entity.Property(e => e.BaseImponible).HasColumnName("BASE_IMPONIBLE");
            entity.Property(e => e.CifCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIF_CLIENTE");
            entity.Property(e => e.CifProveedor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CIF_PROVEEDOR");
            entity.Property(e => e.Consumos).HasColumnName("CONSUMOS");
            entity.Property(e => e.Cuotas).HasColumnName("CUOTAS");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Descuentos).HasColumnName("DESCUENTOS");
            entity.Property(e => e.FechaFactura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FECHA_FACTURA");
            entity.Property(e => e.IdAgrupacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ID_AGRUPACION");
            entity.Property(e => e.IdFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID_FACTURA");
            entity.Property(e => e.IdTelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID_TELEFONO");
            entity.Property(e => e.Impuestos).HasColumnName("IMPUESTOS");
            entity.Property(e => e.Nivel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NIVEL");
            entity.Property(e => e.Operador)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OPERADOR");
            entity.Property(e => e.Otros).HasColumnName("OTROS");
            entity.Property(e => e.Porcentaje)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TipoImpuesto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO_IMPUESTO");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
        });

        modelBuilder.Entity<UbicacionEmpleados>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Categoría).HasMaxLength(255);
            entity.Property(e => e.Centro).HasMaxLength(255);
            entity.Property(e => e.Ciudad).HasMaxLength(255);
            entity.Property(e => e.ComunidadAutónoma)
                .HasMaxLength(255)
                .HasColumnName("Comunidad Autónoma");
            entity.Property(e => e.Convenio).HasMaxLength(255);
            entity.Property(e => e.Depend).HasMaxLength(255);
            entity.Property(e => e.DescrConvenio)
                .HasMaxLength(255)
                .HasColumnName("Descr Convenio");
            entity.Property(e => e.Descripción).HasMaxLength(255);
            entity.Property(e => e.Descripción1).HasMaxLength(255);
            entity.Property(e => e.Descripción2).HasMaxLength(255);
            entity.Property(e => e.Descripción3).HasMaxLength(255);
            entity.Property(e => e.DescripciónCategoría)
                .HasMaxLength(255)
                .HasColumnName("Descripción Categoría");
            entity.Property(e => e.DescripciónCentro)
                .HasMaxLength(255)
                .HasColumnName("Descripción Centro");
            entity.Property(e => e.DescripciónPuesto)
                .HasMaxLength(255)
                .HasColumnName("Descripción Puesto");
            entity.Property(e => e.Emplazamiento).HasMaxLength(255);
            entity.Property(e => e.Empleado).HasMaxLength(255);
            entity.Property(e => e.EscalaO)
                .HasMaxLength(255)
                .HasColumnName("*Escala O#");
            entity.Property(e => e.Estado).HasMaxLength(255);
            entity.Property(e => e.Grupo1DeClientes)
                .HasMaxLength(255)
                .HasColumnName("Grupo 1 de Clientes");
            entity.Property(e => e.Grupo2DeClientes)
                .HasMaxLength(255)
                .HasColumnName("Grupo 2 de Clientes");
            entity.Property(e => e.NIF)
                .HasMaxLength(255)
                .HasColumnName("N#I#F#");
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Observaciones).HasMaxLength(255);
            entity.Property(e => e.Oficina).HasMaxLength(255);
            entity.Property(e => e.Provincia).HasMaxLength(255);
            entity.Property(e => e.Puesto).HasMaxLength(255);
            entity.Property(e => e.Responsable).HasMaxLength(255);
            entity.Property(e => e.RégimenTenencia)
                .HasMaxLength(255)
                .HasColumnName("Régimen Tenencia");
            entity.Property(e => e.TipoOficina)
                .HasMaxLength(255)
                .HasColumnName("Tipo Oficina");
            entity.Property(e => e.UN)
                .HasMaxLength(255)
                .HasColumnName("U# N#");
            entity.Property(e => e.UnidadOrganizativa)
                .HasMaxLength(255)
                .HasColumnName("Unidad Organizativa");
            entity.Property(e => e.Área).HasMaxLength(255);
        });

        modelBuilder.Entity<UnidadMedida>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Decripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuarios>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IdEmpleado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idEmpleado");
            entity.Property(e => e.IdGrupo).HasColumnName("idGrupo");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VdfClientesFibra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VDF_ClientesFibra");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EstadoCliente)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FechaGrabacion)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.IdCliente)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VdfComprasFibra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VDF_ComprasFibra");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.FechaGrabacion)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.IdCliente).HasMaxLength(12);
            entity.Property(e => e.ImporteBase).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.ImporteDescuento).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.ImporteTotal).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.NumeroSerie)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoEvento)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VdfConsumosFibra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VDF_ConsumosFibra");

            entity.Property(e => e.Destino).HasMaxLength(50);
            entity.Property(e => e.DestinoGeneral).HasMaxLength(50);
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.FechaGrabacion)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.IdCliente).HasMaxLength(12);
            entity.Property(e => e.Importe).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.NumeroGeografico).HasMaxLength(50);
            entity.Property(e => e.TipoEvento).HasMaxLength(50);
            entity.Property(e => e.TlfnoLlamado).HasMaxLength(50);
        });

        modelBuilder.Entity<VdfServiciosFibra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VDF_ServiciosFibra");

            entity.Property(e => e.CodigoServicio)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionServicio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstadoCrm)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("EstadoCRM");
            entity.Property(e => e.FechaDesinstalacion).HasColumnType("datetime");
            entity.Property(e => e.FechaGrabacion)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.FechaInstalacion).HasColumnType("datetime");
            entity.Property(e => e.IdCliente)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Instancia).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Paquete)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Rgu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RGU");
            entity.Property(e => e.TelefonoAsociado)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VodafoneInventario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VodafoneInventario");

            entity.Property(e => e.NombreEmp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_EMP");
            entity.Property(e => e.TelefExt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEF_EXT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
