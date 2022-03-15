﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utils
{
    public class Field
    {
        private bool m_Key;
        public bool key
        {
            get { return this.m_Key; }
            set { this.m_Key = value; }
        }

        private String m_Name;
        public String name
        {
            get { return this.m_Name; }
            set { this.m_Name = value; }
        }

        private String m_GridDisplayText;
        public String gridDisplayText
        {
            get { return this.m_GridDisplayText; }
            set { this.m_GridDisplayText = value; }
        }

        private int m_GridDisplaySize;
        public int gridDisplaySize
        {
            get { return this.m_GridDisplaySize; }
            set { this.m_GridDisplaySize = value; }
        }

        private String m_EditDisplayText;
        public String editDisplayText
        {
            get { return this.m_EditDisplayText; }
            set { this.m_EditDisplayText = value; }
        }

        private int m_EditDisplaySize;
        public int editDisplaySize
        {
            get { return this.m_EditDisplaySize; }
            set { this.m_EditDisplaySize = value; }
        }

        private int m_Length;
        public int length
        {
            get { return this.m_Length; }
            set { this.m_Length = value; }
        }

        private bool m_Required;
        public bool required
        {
            get { return this.m_Required; }
            set { this.m_Required = value; }
        }

        private bool m_Enabled;
        public bool enabled
        {
            get { return this.m_Enabled; }
            set { this.m_Enabled = value; }
        }

        private bool m_OboutDropBox;
        public bool oboutDropBox
        {
            get { return this.m_OboutDropBox; }
            set { this.m_OboutDropBox = value; }
        }

        private bool m_AutoGenerated;
        public bool autoGenerated
        {
            get { return this.m_AutoGenerated; }
            set { this.m_AutoGenerated = value; }
        }

        private String m_SubFieldName;
        public String subFieldName
        {
            get { return this.m_SubFieldName; }
            set { this.m_SubFieldName = value; }
        }

        private Boolean m_CargaParcial;
        public Boolean cargaParcial
        {
            get { return this.m_CargaParcial; }
        }

        private String m_ViewFormat;
        public String viewFormat
        {
            get { return this.m_ViewFormat; }
            set { this.m_ViewFormat = value; }
        }


        private String m_EditFormat;
        public String editFormat
        {
            get { return this.m_EditFormat; }
            set { this.m_EditFormat = value; }
        }

        private Boolean m_UseDecimalPlaces;
        public Boolean useDecimalPlaces
        {
            get { return this.m_UseDecimalPlaces; }
            set { this.m_UseDecimalPlaces = value; }
        }

        private String m_ReportFilterName;
        public String reportFilterName
        {
            get { return this.m_ReportFilterName; }
            set { this.m_ReportFilterName = value; }
        }

        private String m_ReportFilterMask;
        public String reportFilterMask
        {
            get { return this.m_ReportFilterMask; }
            set { this.m_ReportFilterMask = value; }
        }

        private String m_ReportFilterEntryFormat;
        public String reportFilterEntryFormat
        {
            get { return this.m_ReportFilterEntryFormat; }
            set { this.m_ReportFilterEntryFormat  = value; }
        }

        public String reportFilterValueFormat
        {
            get { return this.m_ReportFilterValueFormat; }
            set { this.m_ReportFilterValueFormat = value; }
        }

        private String m_ReportFilterValueFormat;

        private int m_ReportFilterSize;
        public int reportFilterSize
        {
            get { return this.m_ReportFilterSize; }
            set { this.m_ReportFilterSize = value; }
        }

        private Boolean m_ReportFilterAllowInverval;
        public Boolean reportFilterAllowInverval
        {
            get { return this.m_ReportFilterAllowInverval; }
            set { this.m_ReportFilterAllowInverval = value; }
        }

        private String m_ReportFilterValues;
        public String reportFilterValues
        {
            get { return this.m_ReportFilterValues; }
            set { this.m_ReportFilterValues = value; }
        }

        private String m_ReportFilterWhereColumn;
        public String reportFilterWhereColumn
        {
            get { return this.m_ReportFilterWhereColumn; }
            set { this.m_ReportFilterWhereColumn = value; }
        }

        private bool m_ShowField;
        public bool showField
        {

            get { return this.m_ShowField; }
            set { this.m_ShowField = value; }
        }

        public Field
        (
            bool key,
            String name,
            String gridDisplayText,
            int gridDisplaySize,
            String editDisplayText,
            int editDisplaySize,
            int length,
            bool required,
            bool enabled,
            bool oboutDropBox,
            bool autoGenerated,
            String subFieldName,
            Boolean cargaParcial,
            String viewFormat,
            String editFormat,
            Boolean useDecimalPlaces,
            Boolean showField,
            String filterName,
            String filterMask,
            String filterEntryFormat,
            String filterValueFormat,
            int filterSize,
            bool filterAllowInterval,
            String filterValues,
            String filterWhereColumn
        )
        {
            this.m_Key = key;
            this.m_Name = name;
            this.m_GridDisplayText = gridDisplayText;
            this.m_GridDisplaySize = gridDisplaySize;

            this.m_EditDisplayText = editDisplayText;
            this.m_EditDisplaySize = editDisplaySize;
            this.m_ShowField = showField;
            this.m_Length = length;
            this.m_Required = required;
            this.m_Enabled = enabled;
            this.m_OboutDropBox = oboutDropBox;
            this.m_AutoGenerated = autoGenerated;
            this.m_SubFieldName = subFieldName;
            this.m_CargaParcial = cargaParcial;
            this.m_ViewFormat = viewFormat;
            this.m_EditFormat = editFormat;
            this.m_UseDecimalPlaces = useDecimalPlaces;

            this.m_ReportFilterName = filterName;
            this.m_ReportFilterMask = filterMask;
            this.m_ReportFilterEntryFormat = filterEntryFormat;
            this.m_ReportFilterValueFormat = filterValueFormat;

            this.m_ReportFilterSize = filterSize;
            this.m_ReportFilterAllowInverval = filterAllowInterval;
            this.m_ReportFilterValues = filterValues;
            this.m_ReportFilterWhereColumn = filterWhereColumn;
        }
    }
}