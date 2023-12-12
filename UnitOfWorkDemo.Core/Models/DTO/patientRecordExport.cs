using PMS.Core.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Models;
using System.Diagnostics.CodeAnalysis;

namespace PMS.Core.Models.DTO
{
    public class patientRecordExport
    {
        
           
           // public int PatientMedicalRecordID { get; set; }

           
         //   public int PatientProfileID { get; set; }
            [AllowNull]
            public Patient? PatientProfile { get; set; }
            [AllowNull]
            public PatientCategories PatientTypeID { get; set; }
            [AllowNull]
            public string BHTNumber { get; set; }

            [AllowNull]
            public ReasonExport? Reason { get; set; }
            [AllowNull]
            public string? Surgery { get; set; }
            [AllowNull]
            public string? IndicationForTheSurgery { get; set; }
            [AllowNull]
            public string? IndicationForAdmissionToTheICU { get; set; }
            [AllowNull]
            public bool? TranexamicAcidGivenOrNot { get; set; }
            [AllowNull]
            public string? PreOpBP_mmHg { get; set; }
            [AllowNull]
            public string? PreOpHR_bpm { get; set; }
            [AllowNull]
            public string? PreOpRR_bpm { get; set; }
            [AllowNull]
            public string? PreOpBloodUrea_mg_dL { get; set; }
            [AllowNull]
            public string? PreOpNa { get; set; }
            [AllowNull]
            public string? PreOpK { get; set; }
            [AllowNull]
            public string? PreOpSCcreatinine { get; set; }
            [AllowNull]
            public string? PreOpHB_g_dL { get; set; }
            [AllowNull]
            public string? PreOpWBC_103 { get; set; }
            [AllowNull]
            public string? PreOpFBS_mg_dL { get; set; }
            [AllowNull]
            public string? PreOpNeutrophilCount { get; set; }
            [AllowNull]
            public string? PostOpDay1BP { get; set; }
            [AllowNull]
            public string? PostOpDay1HR { get; set; }
            [AllowNull]
            public string? PostOpDay1RR { get; set; }
            [AllowNull]
            public string? PostOpDay1BloodUrea { get; set; }
            [AllowNull]
            public string? PostOpDay1SerumNa { get; set; }
            [AllowNull]
            public string? PostOpDay1SerumK { get; set; }
            [AllowNull]
            public string? PostOpDay1SerumCreatinine { get; set; }
            [AllowNull]
            public string? PostOpDay1HB { get; set; }
            [AllowNull]
            public string? PostOpDay1WBC { get; set; }
            [AllowNull]
            public string? PostOpDay1FBS_mg_dL { get; set; }
            [AllowNull]
            public string? PostOpDay1Neutrophil { get; set; }
            [AllowNull]
            public string? PostOpD3BP { get; set; }
            [AllowNull]
            public string? PostOpD3HR { get; set; }
            [AllowNull]
            public string? PostOpD3RR { get; set; }
            [AllowNull]
            public string? PostOpD3BloodUrea { get; set; }
            [AllowNull]
            public string? PostOpD3SerumNa { get; set; }
            [AllowNull]
            public string? PostOpD3SerumK { get; set; }
            [AllowNull]
            public string? PostOpD3SerumCreatinine { get; set; }
            [AllowNull]
            public string? PostOpD3HB { get; set; }
            [AllowNull]
            public string? PostOpD3WBC { get; set; }
            [AllowNull]
            public string? PostOpD3FBS { get; set; }
            [AllowNull]
            public string? PostOpD3NeutrophilCount_103_uL { get; set; }
            [AllowNull]
            public string? PostOpD5BP { get; set; }
            [AllowNull]
            public string? PostOpD5HR { get; set; }
            [AllowNull]
            public string? PostOpD5RR { get; set; }
            [AllowNull]
            public string? PostOpD5BloodUrea { get; set; }
            [AllowNull]
            public string? PostOpD5SerumNa { get; set; }
            [AllowNull]
            public string? PostOpD5SerumK { get; set; }
            [AllowNull]
            public string? PostOpD5SerumCreatinine { get; set; }
            [AllowNull]
            public string? PostOpD5HB { get; set; }
            [AllowNull]
            public string? PostOpD5WBC { get; set; }
            [AllowNull]
            public string? PostOpD5FBS { get; set; }
            [AllowNull]
            public string? PostOpD5Neutrophil { get; set; }
            [AllowNull]
            public string? Height_cm { get; set; }
            [AllowNull]
            public string? Weight_kg { get; set; }
            [AllowNull]
            public string? BMI { get; set; }
            [AllowNull]
            public DateTime? DateofSurgery { get; set; }
            [AllowNull]
            public bool Hypertension { get; set; }
            [AllowNull]
            public bool? DLD { get; set; }
            [AllowNull]
            public bool? DM { get; set; }
            [AllowNull]
            public bool? Thyroid { get; set; }
            [AllowNull]
            public string? Others { get; set; }
            [AllowNull]
            public bool? IschemicHeartDiseases { get; set; }
            [AllowNull]
            public string? Other1 { get; set; }
            [AllowNull]
            public string? Other2 { get; set; }
            [AllowNull]
            public string? PeripheralNeuropathies { get; set; }
            [AllowNull]
            public string? Stroke { get; set; }
            [AllowNull]
            public string? OtherBoneDissordersInLimbs_congenital { get; set; }
            [AllowNull]
            public string? OtherBoneDissordersInLimbs_traumatic { get; set; }
            [AllowNull]
            public string? HxOfOtherMSKInjuriesAndPains { get; set; }
            [AllowNull]
            public string? Hepato_Gastrointestinal { get; set; }
            [AllowNull]
            public string? Respiratory { get; set; }
            [AllowNull]
            public string? Renal { get; set; }
            [AllowNull]
            public string? Other { get; set; }
            [AllowNull]
            public string? PerOperativeBloodLoss { get; set; }
            [AllowNull]
            public string? BloodLossInTheDrainD2 { get; set; }
            [AllowNull]
            public string? BloodLossInTheDrainD1_D2 { get; set; }
            [AllowNull]
            public string? TorniquetTimeMin { get; set; }
            [AllowNull]
            public string? NOofPostOpBloodTransfussions { get; set; }
            [AllowNull]
            public string? N0ofPostOpFFPTransfussions { get; set; }
            [AllowNull]
            public string? TotalOperativeRoomTime_min { get; set; }
            [AllowNull]
            public string? BoneAvolsion { get; set; }
            [AllowNull]
            public string? LigametAvulsions { get; set; }
            [AllowNull]
            public string? IatrogenicFactors { get; set; }
            [AllowNull]
            public string? SuperficialWoundInfections_1st { get; set; }
            [AllowNull]
            public string? DeepWoundInfections_1st { get; set; }
            [AllowNull]
            public string? QuadricepMuscleRupture_1st { get; set; }
            [AllowNull]
            public string? SkinOpening_1st { get; set; }
            [AllowNull]
            public string? FatEmbolism_1st { get; set; }
            [AllowNull]
            public string? SurgicalWoundComplication_1st { get; set; }
            [AllowNull]
            public string? Hematoma_1st { get; set; }
            [AllowNull]
            public string? ChestComplications_1st { get; set; }
            [AllowNull]
            public string? SuperficialWoundInfections_2nd { get; set; }
            [AllowNull]
            public string? DeepWoundInfections_2nd { get; set; }
            [AllowNull]
            public string? QuadricepMuscleRupture_2st { get; set; }
            [AllowNull]
            public string? SkinOpening_2st { get; set; }
            [AllowNull]
            public string? FatEmbolism_2st { get; set; }
            [AllowNull]
            public string? SurgicalWoundComplication_2st { get; set; }
            [AllowNull]
            public string? Hematoma_2st { get; set; }
            [AllowNull]
            public string? ChestComplications_2st { get; set; }
            [AllowNull]
            public string? SuperficialWoundInfections_Intermediate { get; set; }
            [AllowNull]
            public string? DeepWoundInfections_Intermediate { get; set; }
            [AllowNull]
            public string? QuadricepMuscleRupture_Intermediate { get; set; }
            [AllowNull]
            public string? SkinOpening_Intermediate { get; set; }
            [AllowNull]
            public string? FatEmbolism_2st_Intermediate { get; set; }
            [AllowNull]
            public string? SurgicalWoundComplication_Intermediate { get; set; }
            [AllowNull]
            public string? Hematoma_Intermediate { get; set; }
            [AllowNull]
            public string? ChestComplications_Intermediate { get; set; }
            [AllowNull]
            public string? SuperficialWoundInfections_Late { get; set; }
            [AllowNull]
            public string? DeepWoundInfections_Late { get; set; }
            [AllowNull]
            public string? QuadricepMuscleRupture_Late { get; set; }
            [AllowNull]
            public string? SkinOpening_Late { get; set; }
            [AllowNull]
            public string? FatEmbolism_Late { get; set; }
            [AllowNull]
            public string? SurgicalWoundComplication_Late { get; set; }
            [AllowNull]
            public string? Hematoma_Late { get; set; }
            [AllowNull]
            public string? ChestComplications_Late { get; set; }
            [AllowNull]
            public string? PainTolerance_PostOpD1 { get; set; }
            [AllowNull]
            public string? PainTolerance_beforeDischarge { get; set; }
            [AllowNull]
            public string? NoofDaysInTheICU { get; set; }
            [AllowNull]
            public string? EffectivenessInMobilization { get; set; }
            [AllowNull]
            public string? NoofDaysInTheHospital { get; set; }
            [AllowNull]
            public string? MedicalRecordUrl { get; set; }
            [AllowNull]
            public string? medicalRecordFileName { get; set; }
            [AllowNull]
            public DateTime? CreatedDate { get; set; }
            
        ///  Kept The removed  Items commented  in case they request them again 
            //public long? CreatedBy { get; set; }
            //[AllowNull]
            //public DateTime? ModifiedDate { get; set; }
            //[AllowNull]
            //public long? ModifiedBy { get; set; }
            //[AllowNull]
            //public string? IsDeleted { get; set; }
            //[AllowNull]
            //public DateTime? DeletedDate { get; set; }
            //[AllowNull]
            //public string? DeletedBy { get; set; }
        }

    
    public class ReasonExport
    {
       
        public string? ReasonDescription { get; set; }
    };

}

