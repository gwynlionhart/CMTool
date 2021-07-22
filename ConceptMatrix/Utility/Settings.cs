﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConceptMatrix.Utility
{
    [XmlRoot]
    public class Settings
    {
        #region Singleton
        [XmlIgnore]
        private static Settings instance;
        [XmlIgnore]
        public static Settings Instance
        {
            get
            {
                if (instance == null)
                    instance = new Settings();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        #endregion
		public string Version { get; set; }
        public CharacterOffsets Character { get; set; }
        public PositionOffsets Position { get; set; }
        public BonesOffsets Bones { get; set; }
    }
    
    [Serializable]
    public struct CharacterOffsets
    {
        public string ActorID { get; set; }
        public string AltCheckPlayerFrozen { get; set; }
        public string EmoteIsPlayerFrozen { get; set; }
        public string CharacterRender { get; set; }
        public string HDR { get; set; }
        public string Brightness { get; set; }
        public string Contrast { get; set; }
        public string FilterEnable { get; set; }
        public string FilterAoB { get; set; }
        public string Exposure { get; set; }
        public string Filmic { get; set; }
        public string SHDR { get; set; }
        public string Colorfulness { get; set; }
        public string Contrast2 { get; set; }
        public string Colorfulnesss2 { get; set; }
        public string Gamma { get; set; }
        public string Vibrance { get; set; }
        public string GBlue { get; set; }
        public string GGreens { get; set; }
        public string GRed { get; set; }
        public string Name { get; set; }
        public string FCTag { get; set; }
        public string Title { get; set; }
        public string JobIco { get; set; }
        public string Race { get; set; }
        public string RenderDistance { get; set; }

		public string MovingTime { get; set; }

		public string Weather { get; set; }
        public string StatusEffect { get; set; }
        public string ForceWeather { get; set; }
        public string Gender { get; set; }
        public string EyeBrowType { get; set; }
        public string Clan { get; set; }
        public string BodyType { get; set; }
        public string EntityType { get; set; }
		public string EntitySub { get; set; }
		public string FreezeFacial { get; set; }
        public string Territory { get; set; }
        public string DataPath { get; set; }
        public string DataHead { get; set; }
        public string NPCName { get; set; }
        public string NPCModel { get; set; }
        public BodyOffsets Body { get; set; }
        public string TailorMuscle { get; set; }
        public string NameHeight { get; set; }
        public string TailType { get; set; }
        public string ModelType { get; set; }
        public string Transparency { get; set; }
        public string Head { get; set; }
        public string Hair { get; set; }
        public string Jaw { get; set; }
        public string LimbalR { get; set; }
        public string LimbalG { get; set; }
        public string LimbalB { get; set; }
        public string RenderToggle { get; set; }
        public string RHeight { get; set; }
        public string RBust { get; set; }
        public string Highlights { get; set; }
        public string HighlightTone { get; set; }
        public string LimbalEyes { get; set; }
        public string Skintone { get; set; }
        public string FOV2 { get; set; }
        public string HairTone { get; set; }
        public string RightEye { get; set; }
        public string LeftEye { get; set; }
        public string Eye { get; set; }
        public string Nose { get; set; }
        public string Lips { get; set; }
        public string LipsTone { get; set; }
        public string FacePaint { get; set; }
        public string FacePaintColor { get; set; }
        public string FacialFeatures { get; set; }
        public string Emote { get; set; }
        public string EmoteOld { get; set; }
        public string EmoteSpeed1 { get; set; }
        public string EmoteSpeed2 { get; set; }
        public string CameraHeight2 { get; set; }
        public string CameraYAMin { get; set; }
        public string CameraYAMax { get; set; }
        public string Voices { get; set; }
        public string CamX { get; set; }
        public string CamY { get; set; }
        public string CamZ { get; set; }
        public string CamViewX { get; set; }
        public string CamViewY { get; set; }
        public string CamViewZ { get; set; }
        public string FaceCamX { get; set; }
        public string FaceCamY { get; set; }
        public string FaceCamZ { get; set; }
        public string CamAngleX { get; set; }
        public string CamAngleY { get; set; }
        public string CamPanX { get; set; }
        public string CamPanY { get; set; }
        public string Max { get; set; }
        public string Min { get; set; }
        public string CZoom { get; set; }
        public string FOVC { get; set; }
        public string FOVMAX { get; set; }
        public string HeadPiece { get; set; }
        public string HeadV { get; set; }
        public string HeadDye { get; set; }
        public string Chest { get; set; }
        public string ChestV { get; set; }
        public string ChestDye { get; set; }
        public string Arms { get; set; }
        public string ArmsV { get; set; }
        public string ArmsDye { get; set; }
        public string Legs { get; set; }
        public string LegsV { get; set; }
        public string LegsDye { get; set; }
        public string Feet { get; set; }
        public string FeetVa { get; set; }
        public string FeetDye { get; set; }
        public string Ear { get; set; }
        public string EarVa { get; set; }
        public string Neck { get; set; }
        public string NeckVa { get; set; }
        public string Wrist { get; set; }
        public string WristVa { get; set; }
        public string RFinger { get; set; }
        public string RFingerVa { get; set; }
        public string LFinger { get; set; }
        public string LFingerVa { get; set; }
        public string Job { get; set; }
        public string WeaponBase { get; set; }
        public string WeaponV { get; set; }
        public string WeaponDye { get; set; }
        public string WeaponX { get; set; }
        public string WeaponY { get; set; }
        public string WeaponZ { get; set; }
        public string Offhand { get; set; }
        public string OffhandBase { get; set; }
        public string OffhandV { get; set; }
        public string OffhandDye { get; set; }
        public string OffhandX { get; set; }
        public string OffhandY { get; set; }
        public string OffhandZ { get; set; }
        public string OffhandRed { get; set; }
        public string OffhandGreen { get; set; }
        public string OffhandBlue { get; set; }
        public string WeaponRed { get; set; }
        public string WeaponBlue { get; set; }
        public string WeaponGreen { get; set; }
        public string SkinRedPigment { get; set; }
        public string SkinGreenPigment { get; set; }
        public string SkinBluePigment { get; set; }
        public string SkinRedGloss { get; set; }
        public string SkinGreenGloss { get; set; }
        public string SkinBlueGloss { get; set; }
        public string HairRedPigment { get; set; }
        public string HairGreenPigment { get; set; }
        public string HairBluePigment { get; set; }
        public string HairGlowRed { get; set; }
        public string HairGlowGreen { get; set; }
        public string HairGlowBlue { get; set; }
        public string HighlightRedPigment { get; set; }
        public string HighlightGreenPigment { get; set; }
        public string HighlightBluePigment { get; set; }
        public string LeftEyeRed { get; set; }
        public string LeftEyeGreen { get; set; }
        public string LeftEyeBlue { get; set; }
        public string RightEyeRed { get; set; }
        public string RightEyeGreen { get; set; }
        public string RightEyeBlue { get; set; }
        public string LipsBrightness { get; set; }
        public string LipsR { get; set; }
        public string LipsG { get; set; }
        public string LipsB { get; set; }
        public string CameraUpDown { get; set; }
    }

    [Serializable]
    public struct BodyOffsets
    {
        public string Base { get; set; }

        public PositionOffsets Position { get; set; }
        public Vector3Offsets Bust { get; set; }
        public string Height { get; set; }
        public string Wetness { get; set; }
        public string SWetness { get; set; }
        public Vector3Offsets Scale { get; set; }
        public string MuscleTone { get; set; }
        public string TailSize { get; set; }
    }

    [Serializable]
    public struct PositionOffsets
    {
        public string X { get; set; }
        public string Y { get; set; }
        public string Z { get; set; }
        public string Rotation { get; set; }
        public string Rotation2 { get; set; }
        public string Rotation3 { get; set; }
        public string Rotation4 { get; set; }
    }

	[Serializable]
	public struct BonesOffsets
	{
		public string Root_Bone { get; set; }
		public string Abdomen_Bone { get; set; }
		public string Throw_Bone { get; set; }
		public string Waist_Bone { get; set; }
		public string Waist_Size { get; set; }
		public string SpineA_Bone { get; set; }
		public string SpineA_Size { get; set; }
		public string SpineB_Bone { get; set; }
		public string SpineB_Size { get; set; }
		public string SpineC_Bone { get; set; }
		public string SpineC_Size { get; set; }
		public string LegsLeft_Bone { get; set; }
		public string LegsLeft_Size { get; set; }
		public string LegsRight_Bone { get; set; }
		public string LegsRight_Size { get; set; }
		public string HolsterLeft_PoS { get; set; }
		public string HolsterLeft_Bone { get; set; }
		public string HolsterRight_PoS { get; set; }
		public string HolsterRight_Bone { get; set; }
		public string SheatheLeft_PoS { get; set; }
		public string SheatheLeft_Bone { get; set; }
		public string SheatheRight_PoS { get; set; }
		public string SheatheRight_Bone { get; set; }
		public string ClothBackALeft_Bone { get; set; }
		public string ClothBackALeft_Size { get; set; }
		public string ClothBackARight_Bone { get; set; }
		public string ClothBackARight_Size { get; set; }
		public string ClothFrontALeft_Bone { get; set; }
		public string ClothFrontALeft_Size { get; set; }
		public string ClothFrontARight_Bone { get; set; }
		public string ClothFrontARight_Size { get; set; }
		public string ClothSideALeft_Bone { get; set; }
		public string ClothSideALeft_Size { get; set; }
		public string ClothSideARight_Bone { get; set; }
		public string ClothSideARight_Size { get; set; }
		public string KneeLeft_Bone { get; set; }
		public string KneeLeft_Size { get; set; }
		public string KneeRight_Bone { get; set; }
		public string KneeRight_Size { get; set; }
		public string BreastLeft_Bone { get; set; }
		public string BreastLeft_Size { get; set; }
		public string BreastRight_Bone { get; set; }
		public string BreastRight_Size { get; set; }
		public string ClothBackBLeft_Bone { get; set; }
		public string ClothBackBLeft_Size { get; set; }
		public string ClothBackBRight_Bone { get; set; }
		public string ClothBackBRight_Size { get; set; }
		public string ClothFrontBLeft_Bone { get; set; }
		public string ClothFrontBLeft_Size { get; set; }
		public string ClothFrontBRight_Bone { get; set; }
		public string ClothFrontBRight_Size { get; set; }
		public string ClothSideBLeft_Bone { get; set; }
		public string ClothSideBLeft_Size { get; set; }
		public string ClothSideBRight_Bone { get; set; }
		public string ClothSideBRight_Size { get; set; }
		public string CalfLeft_Bone { get; set; }
		public string CalfLeft_Size { get; set; }
		public string CalfRight_Bone { get; set; }
		public string CalfRight_Size { get; set; }
		public string ScabbardLeft_PoS { get; set; }
		public string ScabbardLeft_Bone { get; set; }
		public string ScabbardRight_PoS { get; set; }
		public string ScabbardRight_Bone { get; set; }
		public string Neck_Bone { get; set; }
		public string Neck_Size { get; set; }
		public string ClavicleLeft_Bone { get; set; }
		public string ClavicleLeft_Size { get; set; }
		public string ClavicleRight_Bone { get; set; }
		public string ClavicleRight_Size { get; set; }
		public string ClothBackCLeft_Bone { get; set; }
		public string ClothBackCLeft_Size { get; set; }
		public string ClothBackCRight_Bone { get; set; }
		public string ClothBackCRight_Size { get; set; }
		public string ClothFrontCLeft_Bone { get; set; }
		public string ClothFrontCLeft_Size { get; set; }
		public string ClothFrontCRight_Bone { get; set; }
		public string ClothFrontCRight_Size { get; set; }
		public string ClothSideCLeft_Bone { get; set; }
		public string ClothSideCLeft_Size { get; set; }
		public string ClothSideCRight_Bone { get; set; }
		public string ClothSideCRight_Size { get; set; }
		public string PoleynLeft_Bone { get; set; }
		public string PoleynLeft_Size { get; set; }
		public string PoleynRight_Bone { get; set; }
		public string PoleynRight_Size { get; set; }
		public string FootLeft_Bone { get; set; }
		public string FootLeft_Size { get; set; }
		public string FootRight_Bone { get; set; }
		public string FootRight_Size { get; set; }
		public string Head_Bone { get; set; }
		public string Head_Size { get; set; }
		public string ArmLeft_Bone { get; set; }
		public string ArmLeft_Size { get; set; }
		public string ArmRight_Bone { get; set; }
		public string ArmRight_Size { get; set; }
		public string PauldronLeft_Bone { get; set; }
		public string PauldronRight_Bone { get; set; }
		public string Unknown00_Bone { get; set; }
		public string ToesLeft_Bone { get; set; }
		public string ToesLeft_Size { get; set; }
		public string ToesRight_Bone { get; set; }
		public string ToesRight_Size { get; set; }
		public string HairA_Bone { get; set; }
		public string HairA_Size { get; set; }
		public string HairFrontLeft_Bone { get; set; }
		public string HairFrontLeft_Size { get; set; }
		public string HairFrontRight_Bone { get; set; }
		public string HairFrontRight_Size { get; set; }
		public string EarLeft_Bone { get; set; }
		public string EarLeft_Size { get; set; }
		public string EarRight_Bone { get; set; }
		public string EarRight_Size { get; set; }
		public string ForearmLeft_Bone { get; set; }
		public string ForearmLeft_Size { get; set; }
		public string ForearmRight_Bone { get; set; }
		public string ForearmRight_Size { get; set; }
		public string ShoulderLeft_Bone { get; set; }
		public string ShoulderLeft_Size { get; set; }
		public string ShoulderRight_Bone { get; set; }
		public string ShoulderRight_Size { get; set; }
		public string HairB_Bone { get; set; }
		public string HairB_Size { get; set; }
		public string HandLeft_Bone { get; set; }
		public string HandLeft_Size { get; set; }
		public string HandRight_Bone { get; set; }
		public string HandRight_Size { get; set; }
		public string ShieldLeft_Bone { get; set; }
		public string ShieldRight_Bone { get; set; }
		public string EarringALeft_Bone { get; set; }
		public string EarringALeft_PoS { get; set; }
		public string EarringARight_Bone { get; set; }
		public string EarringARight_PoS { get; set; }
		public string ElbowLeft_Bone { get; set; }
		public string ElbowLeft_Size { get; set; }
		public string ElbowRight_Bone { get; set; }
		public string ElbowRight_Size { get; set; }
		public string CouterLeft_Bone { get; set; }
		public string CouterLeft_Size { get; set; }
		public string CouterRight_Bone { get; set; }
		public string CouterRight_Size { get; set; }
		public string WristLeft_Bone { get; set; }
		public string WristLeft_Size { get; set; }
		public string WristRight_Bone { get; set; }
		public string WristRight_Size { get; set; }
		public string IndexALeft_Bone { get; set; }
		public string IndexALeft_Size { get; set; }
		public string IndexARight_Bone { get; set; }
		public string IndexARight_Size { get; set; }
		public string PinkyALeft_Bone { get; set; }
		public string PinkyALeft_Size { get; set; }
		public string PinkyARight_Bone { get; set; }
		public string PinkyARight_Size { get; set; }
		public string RingALeft_Bone { get; set; }
		public string RingALeft_Size { get; set; }
		public string RingARight_Bone { get; set; }
		public string RingARight_Size { get; set; }
		public string MiddleALeft_Bone { get; set; }
		public string MiddleALeft_Size { get; set; }
		public string MiddleARight_Bone { get; set; }
		public string MiddleARight_Size { get; set; }
		public string ThumbALeft_Bone { get; set; }
		public string ThumbALeft_Size { get; set; }
		public string ThumbARight_Bone { get; set; }
		public string ThumbARight_Size { get; set; }
		public string WeaponLeft_PoS { get; set; }
		public string WeaponLeft_Bone { get; set; }
		public string WeaponRight_PoS { get; set; }
		public string WeaponRight_Bone { get; set; }
		public string EarringBLeft_Bone { get; set; }
		public string EarringBLeft_PoS { get; set; }
		public string EarringBRight_Bone { get; set; }
		public string EarringBRight_PoS { get; set; }
		public string IndexBLeft_Bone { get; set; }
		public string IndexBLeft_Size { get; set; }
		public string IndexBRight_Bone { get; set; }
		public string IndexBRight_Size { get; set; }
		public string PinkyBLeft_Bone { get; set; }
		public string PinkyBLeft_Size { get; set; }
		public string PinkyBRight_Bone { get; set; }
		public string PinkyBRight_Size { get; set; }
		public string RingBLeft_Bone { get; set; }
		public string RingBLeft_Size { get; set; }
		public string RingBRight_Bone { get; set; }
		public string RingBRight_Size { get; set; }
		public string MiddleBLeft_Bone { get; set; }
		public string MiddleBLeft_Size { get; set; }
		public string MiddleBRight_Bone { get; set; }
		public string MiddleBRight_Size { get; set; }
		public string ThumbBLeft_Bone { get; set; }
		public string ThumbBLeft_Size { get; set; }
		public string ThumbBRight_Bone { get; set; }
		public string ThumbBRight_Size { get; set; }
		public string TailA_Bone { get; set; }
		public string TailA_Size { get; set; }
		public string TailB_Bone { get; set; }
		public string TailB_Size { get; set; }
		public string TailC_Bone { get; set; }
		public string TailC_Size { get; set; }
		public string TailD_Bone { get; set; }
		public string TailD_Size { get; set; }
		public string TailE_Bone { get; set; }
		public string TailE_Size { get; set; }
		public string RootHead_Bone { get; set; }
		public string Jaw_Bone { get; set; }
		public string Jaw_Size { get; set; }
		public string EyelidLowerLeft_Bone { get; set; }
		public string EyelidLowerLeft_Size { get; set; }
		public string EyelidLowerRight_Bone { get; set; }
		public string EyelidLowerRight_Size { get; set; }
		public string EyeLeft_Bone { get; set; }
		public string EyeLeft_Size { get; set; }
		public string EyeRight_Bone { get; set; }
		public string EyeRight_Size { get; set; }
		public string Nose_Bone { get; set; }
		public string Nose_Size { get; set; }
		public string CheekLeft_Bone { get; set; }
		public string CheekLeft_Size { get; set; }
		public string HrothWhiskersLeft_Bone { get; set; }
		public string HrothWhiskersLeft_Size { get; set; }
		public string CheekRight_Bone { get; set; }
		public string CheekRight_Size { get; set; }
		public string HrothWhiskersRight_Bone { get; set; }
		public string HrothWhiskersRight_Size { get; set; }
		public string LipsLeft_Bone { get; set; }
		public string LipsLeft_Size { get; set; }
		public string HrothEyebrowLeft_Bone { get; set; }
		public string HrothEyebrowLeft_Size { get; set; }
		public string LipsRight_Bone { get; set; }
		public string LipsRight_Size { get; set; }
		public string HrothEyebrowRight_Bone { get; set; }
		public string HrothEyebrowRight_Size { get; set; }
		public string EyebrowLeft_Bone { get; set; }
		public string EyebrowLeft_Size { get; set; }
		public string EyebrowRight_Bone { get; set; }
		public string EyebrowRight_Size { get; set; }
		public string HrothBridge_Bone { get; set; }
		public string HrothBridge_Size { get; set; }
		public string HrothBrowLeft_Bone { get; set; }
		public string HrothBrowLeft_Size { get; set; }
		public string Bridge_Bone { get; set; }
		public string Bridge_Size { get; set; }
		public string HrothBrowRight_Bone { get; set; }
		public string HrothBrowRight_Size { get; set; }
		public string BrowLeft_Bone { get; set; }
		public string BrowLeft_Size { get; set; }
		public string HrothJawUpper_Bone { get; set; }
		public string HrothJawUpper_Size { get; set; }
		public string BrowRight_Bone { get; set; }
		public string BrowRight_Size { get; set; }
		public string HrothLipUpper_Bone { get; set; }
		public string HrothLipUpper_Size { get; set; }
		public string LipUpperA_Bone { get; set; }
		public string LipUpperA_Size { get; set; }
		public string HrothEyelidUpperLeft_Bone { get; set; }
		public string HrothEyelidUpperLeft_Size { get; set; }
		public string EyelidUpperLeft_Bone { get; set; }
		public string EyelidUpperLeft_Size { get; set; }
		public string HrothEyelidUpperRight_Bone { get; set; }
		public string HrothEyelidUpperRight_Size { get; set; }
		public string EyelidUpperRight_Bone { get; set; }
		public string EyelidUpperRight_Size { get; set; }
		public string HrothLipsLeft_Bone { get; set; }
		public string HrothLipsLeft_Size { get; set; }
		public string LipLowerA_Bone { get; set; }
		public string LipLowerA_Size { get; set; }
		public string HrothLipsRight_Bone { get; set; }
		public string HrothLipsRight_Size { get; set; }
		public string VieraEar01ALeft_Bone { get; set; }
		public string VieraEar01ALeft_Size { get; set; }
		public string LipUpperB_Bone { get; set; }
		public string LipUpperB_Size { get; set; }
		public string HrothLipUpperLeft_Bone { get; set; }
		public string HrothLipUpperLeft_Size { get; set; }
		public string VieraEar01ARight_Bone { get; set; }
		public string VieraEar01ARight_Size { get; set; }
		public string LipLowerB_Bone { get; set; }
		public string LipLowerB_Size { get; set; }
		public string HrothLipUpperRight_Bone { get; set; }
		public string HrothLipUpperRight_Size { get; set; }
		public string VieraEar02ALeft_Bone { get; set; }
		public string VieraEar02ALeft_Size { get; set; }
		public string HrothLipLower_Bone { get; set; }
		public string HrothLipLower_Size { get; set; }
		public string VieraEar02ARight_Bone { get; set; }
		public string VieraEar02ARight_Size { get; set; }
		public string VieraEar03ALeft_Bone { get; set; }
		public string VieraEar03ALeft_Size { get; set; }
		public string VieraEar03ARight_Bone { get; set; }
		public string VieraEar03ARight_Size { get; set; }
		public string VieraEar04ALeft_Bone { get; set; }
		public string VieraEar04ALeft_Size { get; set; }
		public string VieraEar04ARight_Bone { get; set; }
		public string VieraEar04ARight_Size { get; set; }
		public string VieraLipLowerA_Bone { get; set; }
		public string VieraLipLowerA_Size { get; set; }
		public string VieraLipUpperB_Bone { get; set; }
		public string VieraLipUpperB_Size { get; set; }
		public string VieraEar01BLeft_Bone { get; set; }
		public string VieraEar01BLeft_Size { get; set; }
		public string VieraEar01BRight_Bone { get; set; }
		public string VieraEar01BRight_Size { get; set; }
		public string VieraEar02BLeft_Bone { get; set; }
		public string VieraEar02BLeft_Size { get; set; }
		public string VieraEar02BRight_Bone { get; set; }
		public string VieraEar02BRight_Size { get; set; }
		public string VieraEar03BLeft_Bone { get; set; }
		public string VieraEar03BLeft_Size { get; set; }
		public string VieraEar03BRight_Bone { get; set; }
		public string VieraEar03BRight_Size { get; set; }
		public string VieraEar04BLeft_Bone { get; set; }
		public string VieraEar04BLeft_Size { get; set; }
		public string VieraEar04BRight_Bone { get; set; }
		public string VieraEar04BRight_Size { get; set; }
		public string VieraLipLowerB_Bone { get; set; }
		public string VieraLipLowerB_Size { get; set; }
		public string ExHair_Value { get; set; }
		public string ExRootHair_Bone { get; set; }
		public string ExHairA_Bone { get; set; }
		public string ExHairA_Size { get; set; }
		public string ExHairB_Bone { get; set; }
		public string ExHairB_Size { get; set; }
		public string ExHairC_Bone { get; set; }
		public string ExHairC_Size { get; set; }
		public string ExHairD_Bone { get; set; }
		public string ExHairD_Size { get; set; }
		public string ExHairE_Bone { get; set; }
		public string ExHairE_Size { get; set; }
		public string ExHairF_Bone { get; set; }
		public string ExHairF_Size { get; set; }
		public string ExHairG_Bone { get; set; }
		public string ExHairG_Size { get; set; }
		public string ExHairH_Bone { get; set; }
		public string ExHairH_Size { get; set; }
		public string ExHairI_Bone { get; set; }
		public string ExHairI_Size { get; set; }
		public string ExHairJ_Bone { get; set; }
		public string ExHairJ_Size { get; set; }
		public string ExHairK_Bone { get; set; }
		public string ExHairK_Size { get; set; }
		public string ExHairL_Bone { get; set; }
		public string ExHairL_Size { get; set; }
		public string ExMet_Value { get; set; }
		public string ExRootMet_Bone { get; set; }
		public string ExMetA_Bone { get; set; }
		public string ExMetA_Size { get; set; }
		public string ExMetB_Bone { get; set; }
		public string ExMetB_Size { get; set; }
		public string ExMetC_Bone { get; set; }
		public string ExMetC_Size { get; set; }
		public string ExMetD_Bone { get; set; }
		public string ExMetD_Size { get; set; }
		public string ExMetE_Bone { get; set; }
		public string ExMetE_Size { get; set; }
		public string ExMetF_Bone { get; set; }
		public string ExMetF_Size { get; set; }
		public string ExMetG_Bone { get; set; }
		public string ExMetG_Size { get; set; }
		public string ExMetH_Bone { get; set; }
		public string ExMetH_Size { get; set; }
		public string ExMetI_Bone { get; set; }
		public string ExMetI_Size { get; set; }
		public string ExMetJ_Bone { get; set; }
		public string ExMetJ_Size { get; set; }
		public string ExMetK_Bone { get; set; }
		public string ExMetK_Size { get; set; }
		public string ExMetL_Bone { get; set; }
		public string ExMetL_Size { get; set; }
		public string ExMetM_Bone { get; set; }
		public string ExMetM_Size { get; set; }
		public string ExMetN_Bone { get; set; }
		public string ExMetN_Size { get; set; }
		public string ExMetO_Bone { get; set; }
		public string ExMetO_Size { get; set; }
		public string ExMetP_Bone { get; set; }
		public string ExMetP_Size { get; set; }
		public string ExMetQ_Bone { get; set; }
		public string ExMetQ_Size { get; set; }
		public string ExMetR_Bone { get; set; }
		public string ExMetR_Size { get; set; }
		public string ExTop_Value { get; set; }
		public string ExRootTop_Bone { get; set; }
		public string ExTopA_Bone { get; set; }
		public string ExTopA_Size { get; set; }
		public string ExTopB_Bone { get; set; }
		public string ExTopB_Size { get; set; }
		public string ExTopC_Bone { get; set; }
		public string ExTopC_Size { get; set; }
		public string ExTopD_Bone { get; set; }
		public string ExTopD_Size { get; set; }
		public string ExTopE_Bone { get; set; }
		public string ExTopE_Size { get; set; }
		public string ExTopF_Bone { get; set; }
		public string ExTopF_Size { get; set; }
		public string ExTopG_Bone { get; set; }
		public string ExTopG_Size { get; set; }
		public string ExTopH_Bone { get; set; }
		public string ExTopH_Size { get; set; }
		public string ExTopI_Bone { get; set; }
		public string ExTopI_Size { get; set; }
	}

	[Serializable]
    public struct Vector3Offsets
    {
        public string Base { get; set; }

        public string X { get; set; }
        public string Y { get; set; }
        public string Z { get; set; }
    }
}
