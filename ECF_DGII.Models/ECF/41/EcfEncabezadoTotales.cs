using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ECF_DGII.Models.ECF._41;

[GeneratedCode("XmlSchemaClassGenerator", "2.1.1094.0")]
[Serializable]
[XmlType("EcfEncabezadoTotales", Namespace = "", AnonymousType = true)]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class EcfEncabezadoTotales
{
    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("MontoGravadoTotal", Form = XmlSchemaForm.Unqualified)]
    public decimal MontoGravadoTotal { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the MontoGravadoTotal property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool MontoGravadoTotalSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("MontoGravadoI1", Form = XmlSchemaForm.Unqualified)]
    public decimal MontoGravadoI1 { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the MontoGravadoI1 property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool MontoGravadoI1Specified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("MontoGravadoI2", Form = XmlSchemaForm.Unqualified)]
    public decimal MontoGravadoI2 { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the MontoGravadoI2 property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool MontoGravadoI2Specified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("MontoGravadoI3", Form = XmlSchemaForm.Unqualified)]
    public decimal MontoGravadoI3 { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the MontoGravadoI3 property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool MontoGravadoI3Specified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("MontoExento", Form = XmlSchemaForm.Unqualified)]
    public decimal MontoExento { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the MontoExento property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool MontoExentoSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,2}.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,2}")]
    [XmlElement("ITBIS1", Form = XmlSchemaForm.Unqualified)]
    public sbyte Itbis1 { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the Itbis1 property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool Itbis1Specified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,2}.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,2}")]
    [XmlElement("ITBIS2", Form = XmlSchemaForm.Unqualified)]
    public sbyte Itbis2 { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the Itbis2 property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool Itbis2Specified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,2}.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,2}")]
    [XmlElement("ITBIS3", Form = XmlSchemaForm.Unqualified)]
    public sbyte Itbis3 { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the Itbis3 property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool Itbis3Specified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("TotalITBIS", Form = XmlSchemaForm.Unqualified)]
    public decimal TotalItbis { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the TotalItbis property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool TotalItbisSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("TotalITBIS1", Form = XmlSchemaForm.Unqualified)]
    public decimal TotalItbis1 { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the TotalItbis1 property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool TotalItbis1Specified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("TotalITBIS2", Form = XmlSchemaForm.Unqualified)]
    public decimal TotalItbis2 { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the TotalItbis2 property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool TotalItbis2Specified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("TotalITBIS3", Form = XmlSchemaForm.Unqualified)]
    public decimal TotalItbis3 { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the TotalItbis3 property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool TotalItbis3Specified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [Required]
    [XmlElement("MontoTotal", Form = XmlSchemaForm.Unqualified)]
    public decimal MontoTotal { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [+-]?[0-9]{1,16}(.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[+-]?[0-9]{1,16}(.[0-9]{1,2})?")]
    [XmlElement("MontoPeriodo", Form = XmlSchemaForm.Unqualified)]
    public decimal MontoPeriodo { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the MontoPeriodo property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool MontoPeriodoSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [+-]?[0-9]{1,16}(.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[+-]?[0-9]{1,16}(.[0-9]{1,2})?")]
    [XmlElement("SaldoAnterior", Form = XmlSchemaForm.Unqualified)]
    public decimal SaldoAnterior { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the SaldoAnterior property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool SaldoAnteriorSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("MontoAvancePago", Form = XmlSchemaForm.Unqualified)]
    public decimal MontoAvancePago { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the MontoAvancePago property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool MontoAvancePagoSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [+-]?[0-9]{1,16}(.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[+-]?[0-9]{1,16}(.[0-9]{1,2})?")]
    [XmlElement("ValorPagar", Form = XmlSchemaForm.Unqualified)]
    public decimal ValorPagar { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the ValorPagar property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool ValorPagarSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("TotalITBISRetenido", Form = XmlSchemaForm.Unqualified)]
    public decimal TotalItbisRetenido { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the TotalItbisRetenido property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool TotalItbisRetenidoSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("TotalISRRetencion", Form = XmlSchemaForm.Unqualified)]
    public decimal TotalIsrRetencion { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the TotalIsrRetencion property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool TotalIsrRetencionSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("TotalITBISPercepcion", Form = XmlSchemaForm.Unqualified)]
    public decimal TotalItbisPercepcion { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the TotalItbisPercepcion property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool TotalItbisPercepcionSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("TotalISRPercepcion", Form = XmlSchemaForm.Unqualified)]
    public decimal TotalIsrPercepcion { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the TotalIsrPercepcion property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool TotalIsrPercepcionSpecified { get; set; }
}