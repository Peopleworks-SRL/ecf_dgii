using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ECF_DGII.Models.ECF._46;

[GeneratedCode("XmlSchemaClassGenerator", "2.1.1094.0")]
[Serializable]
[XmlType("EcfSubtotalesSubtotal", Namespace = "", AnonymousType = true)]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class EcfSubtotalesSubtotal
{
    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,2}.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,2}")]
    [XmlElement("NumeroSubTotal", Form = XmlSchemaForm.Unqualified)]
    public sbyte NumeroSubTotal { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the NumeroSubTotal property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool NumeroSubTotalSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Minimum length: 1.</para>
    ///     <para xml:lang="en">Maximum length: 40.</para>
    /// </summary>
    [MinLength(1)]
    [MaxLength(40)]
    [XmlElement("DescripcionSubtotal", Form = XmlSchemaForm.Unqualified)]
    public string DescripcionSubtotal { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,2}.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,2}")]
    [XmlElement("Orden", Form = XmlSchemaForm.Unqualified)]
    public sbyte Orden { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the Orden property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool OrdenSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("SubTotalMontoGravadoTotal", Form = XmlSchemaForm.Unqualified)]
    public decimal SubTotalMontoGravadoTotal { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the SubTotalMontoGravadoTotal property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool SubTotalMontoGravadoTotalSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("SubTotalMontoGravadoI3", Form = XmlSchemaForm.Unqualified)]
    public decimal SubTotalMontoGravadoI3 { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the SubTotalMontoGravadoI3 property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool SubTotalMontoGravadoI3Specified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("SubTotaITBIS", Form = XmlSchemaForm.Unqualified)]
    public decimal SubTotaItbis { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the SubTotaItbis property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool SubTotaItbisSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("SubTotaITBIS3", Form = XmlSchemaForm.Unqualified)]
    public decimal SubTotaItbis3 { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the SubTotaItbis3 property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool SubTotaItbis3Specified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 18.</para>
    ///     <para xml:lang="en">Total number of digits in fraction: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,16}(\.[0-9]{1,2})?.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [XmlElement("MontoSubTotal", Form = XmlSchemaForm.Unqualified)]
    public decimal MontoSubTotal { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the MontoSubTotal property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool MontoSubTotalSpecified { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Total number of digits: 2.</para>
    ///     <para xml:lang="en">Pattern: [0-9]{1,2}.</para>
    /// </summary>
    [RegularExpression("[0-9]{1,2}")]
    [XmlElement("Lineas", Form = XmlSchemaForm.Unqualified)]
    public sbyte Lineas { get; set; }

    /// <summary>
    ///     <para xml:lang="en">Gets or sets a value indicating whether the Lineas property is specified.</para>
    /// </summary>
    [XmlIgnore]
    public bool LineasSpecified { get; set; }
}