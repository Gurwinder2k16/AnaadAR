﻿using System;
using System.Collections.Generic;


	public class ArrayList_cous
	{
		public string eng,punj,hindi,loc;
		string get_eng()
		{
			return eng;
		}
		string get_punj()
		{
			return punj;
		}
		string get_hindi()
		{
			return hindi;
		}
		string get_loc()
		{
			return loc;
		}
		public void set_eng(string val)
		{
			eng = val;
		}
    	public void set_punj(string val)
		{
			punj = val;
		}
	    public void set_hindi(string val)
		{
			hindi = val;
		}
	public void set_loc(string val)
	{
		loc = val;
	}

	}
	public class ArrayList_implem
	{
		public List<ArrayList_cous> history=new List<ArrayList_cous>();
	ArrayList_cous harimandir, baba_budha_ber, baba_deep_singh, guru_ram_das, guru_arjan_dev, guru_hargobind, akal_takhat,DRABBEDKAR,dukh_bhanjan, maharja_ranjit_singh, santokhsar_sahib;
        public ArrayList_implem()
		{
		harimandir = new ArrayList_cous();
		baba_budha_ber = new ArrayList_cous();
		akal_takhat =new ArrayList_cous();
		DRABBEDKAR = new ArrayList_cous();
		santokhsar_sahib = new ArrayList_cous();
		maharja_ranjit_singh =new ArrayList_cous();
		dukh_bhanjan = new ArrayList_cous ();

		//--------------internal
		harimandir.set_loc ("Harimandir sahib");
		harimandir.set_eng ("Sachkhand Sri Harmandir Sahib, also known as Sri Darbar Sahib or Golden Temple, (on account of its scenic beauty and golden coating for English speaking world), is named after Hari(God) the temple of God. The Sikhs all over the world, daily wish to pay visit to Sri Amritsar and to pay obeisance at Sri Harmandir Sahib in their Ardas.Guru Arjan Sahib, the Fifth Nanak, conceived the idea of creating a central place of worship for the Sikhs and he himself designed the architecture of Sri Harmandir Sahib. Earlier the planning to excavate the holy tank (Amritsar or Amrit Sarovar ) was chalked out by Guru Amardas Sahib, the Third Nanak, but it was executed by Guru Ramdas Sahib under the supervision of Baba Budha ji. The land for the site was acquired by the earlier Guru Sahibs on payment or free of cost from the Zamindars (landlords) of native villages. The plan to establish a town settlement was also made. Therefore, the construction work on the Sarovar(the tank) and the town started simultaneously in 1570. The work on both projects completed in 1577 A.D.Guru Arjan Sahib got its foundation laid by a muslim saint Hazrat Mian Mir ji of Lahore on 1st of Magh, 1645 Bikrmi Samvat(December,1588). The construction work was directly supervised by Guru Arjan Sahib himself and he was assisted by the prominent Sikh personalities like Baba Budha ji, Bhai Gurdas ji, Bhai Sahlo ji and many other devoted Sikhs.Unlike erecting the structure on the higher level(a tradition in Hindu Temple architecture), Guru Arjan Sahib got it built on the lower level and unlike Hindu Temples having only one gate for the entrance and exit, Guru Sahib got it open from four sides. Thus he created a symbol of new faith, Sikhism. Guru Sahib made it accessible to every person without any distinction of Caste, creed, sex and religion.The building work completed in 1601 A.D. on Bhadoon Sudi 1st, 1661 Bikrmi Samvat (August/September,1604). Guru Arjan Sahib installed newly created Guru Granth Sahib, in Sri Harmandir Sahib and appointed Baba Budha ji as its first Granthi i.e. the reader of Guru Granth Sahib. After this event it attained the status of ‘Ath Sath Tirath’. Now the Sikh Nation had their own Tirath, a pilgrimage center.");
		harimandir.set_punj (" ਸ੍ੀ ਹਿਰਮੰਦਰ ਸਾਿਹਬ  ਿਜਸ ਨੂੰ ਇਸ ਦੀ ਸਜੀਵ ਸੁੰਦਰਤਾ ਅਤੇ ਇਸ ਉੱਪਰ ਸੋਨੇ ਦੀ ਝਾਲ ਦੇ ਕਾਰਨ ਅੰਗਰੇਜ਼ੀ ਬੋਲਣ ਵਾਿਲਆਂ ਿਵਚ ਇਹ ਗੋਲਡਨ ਟੈਂਪਲ ਦੇ ਨਾਂ ਨਾਲ ਜਾਿਣਆ ਜਾਂਦਾ ਹੈ। ਇਹ ਦੁਨੀਆਂ ਿਵਚ ਆਪਣੀ ਿਵਲੱਖਣ ਥਾਂ ਰੱਖਦਾ ਹੈ। ਇਹ ਨਾਂ ‘ਹਿਰਮੰਦਰ ਸਾਿਹਬ ’ ਹਰੀ/ਪਰਮਾਤਮਾ ਦੇ ਨਾਂ ‘ਤੇ ਹੈ।ਸਾਰੀ ਦੁਨੀਆਂ ਿਵਚ ਿਸੱਖ ਰੋਜ਼ ਹੀ ਆਪਣੀ ਅਰਦਾਸ ਿਵਚ ਸ੍ੀ ਅੰਿਮ੍ਤਸਰ ਆਉਣ ਅਤੇ ਸ੍ੀ ਹਿਰਮੰਦਰ ਸਾਿਹਬ ਮੱਥਾ ਟੇਕ ਕੇ ਸ਼ਰਧਾ-ਸਿਤਕਾਰ ਅਦਾ ਕਰਨ ਦੀ ਲੋਚਾ ਕਰਦਾ ਹੈ।ਪੰਚਮ ਪਾਤਸ਼ਾਹ ਗੁਰੂ ਅਰਜਨ ਸਾਿਹਬ  ਨੂੰ ਿਸੱਖਾਂ ਵਾਸਤੇ ਇਕ ਕੇਂਦਰੀ ਪੂਜਾ ਅਸਥਾਨ ਰਚਣ ਦਾ ਿਖਆਲ ਆਇਆ ਤੇ ਉਨ੍ਾਂ  ਸ੍ੀ ਹਿਰਮੰਦਰ ਸਾਿਹਬ ਦੀ ਿਨਰਮਾਣਕਾਰੀ ਦਾ ਖਾਕਾ ਖੁਦ ਬਣਾਇਆ। ਪੂਰਬਲੇ ਸਮੇਂ ਤੀਸਰੇ ਗੁਰੂ, ਗੁਰੂ ਅਮਰਦਾਸ ਜੀ ਨੇ ਪਿਵੱਤਰ ਸਰੋਵਰ ‘ਅੰਿਮ੍ਤਸਰ’ ਜਾਂ ‘ਅੰਿਮ੍ਤ ਸਰੋਵਰ, ਨੂੰ ਖੁਦਵਾਉਣ ਦੀ ਯੋਜਨਾ ਬਣਾਈ ਸੀ, ਅਤੇ ਇਸਨੂੰ ਗੁਰੂ ਰਾਮਦਾਸ ਸਾਿਹਬ  ਦੁਆਰਾ ਬਾਬਾ ਬੁੱਢਾ ਜੀ ਦੀ ਿਨਗਰਾਨੀ ਿਵਚ ਖੁਦਵਾਇਆ ਿਗਆ ਸੀ। ਸਥਾਨ ਵਾਸਤੇ ਜ਼ਮੀਨ ਪੂਰਬਲੇ ਗੁਰੂ ਸਾਿਹਬ ਾਨ ਦੁਆਰਾ ਸਥਾਨਕ ਿਪਡਾਂ ਦੇ ਿਜੰਮੀਦਾਰਾਂ ਤੋਂ ਨਕਦ ਅਦਾਇਗੀ ਨਾਲ ਪ੍ਾਪਤ ਕਰ ਲਈ ਗਈ ਸੀ। ਇਕ ਨਗਰ ਵਸਾਉਣ ਦੀ ਯੋਜਨਾ ਵੀ ਬਣਾਈ ਗਈ। ਇਸ ਲਈ 1570 ਈ: ਿਵਚ ਸਰੋਵਰ ਅਤੇ ਨਗਰ ‘ਤੇ ਕਾਰਜ ਨਾਲ-ਨਾਲ ਸ਼ੁਰੂ ਹੋਇਆ। ਦੋਨਾਂ ‘ਤੇ ਕਾਰਜ 1577 ਈ: ‘ਚ ਪੂਰਾ ਹੋਇਆ।ਗੁਰੂ ਅਰਜਨ ਸਾਿਹਬ  ਨੇ ਇਸ ਦੀ ਨੀਂਹ 1 ਮਾਘ 1645 ਿਬਕਰਮੀ ਸੰਮਤ (ਦਸੰਬਰ 1588) ‘ਚ ਮੁਸਲਮਾਨ ਫਕੀਰ ਹਜ਼ਰਤ ਮੀਆਂ ਮੀਰ ਜੀ ਤੋਂ ਰਖਵਾਈ ਜੋ ਿਕ ਲਾਹੌਰ ਦੇ ਰਿਹਣ ਵਾਲੇ ਸਨ। ਰਚਨਾ-ਕਾਰਜ ਗੁਰੂ ਅਰਜਨ ਸਾਿਹਬ  ਦੀ ਪ੍ਰਤੱਖ ਰੂਪ ‘ਚ ਕੀਤੀ ਿਨਗਰਾਨੀ ‘ਚ ਹੋਇਆ ਅਤੇ ਬਾਬਾ ਬੁੱਢਾ ਜੀ, ਭਾਈ ਗੁਰਦਾਸ ਜੀ, ਭਾਈ ਸਾਲ੍ੋ  ਜੀ (ਸਾਰੀਆਂ ਪ੍ਿਸੱਧ ਿਸੱਖ ਸ਼ਖਸ਼ੀਅਤਾਂ) ਅਤੇ ਇਸ ਪਿਵੱਤਰ ਕਾਰਜ ਿਵਚ ਕਈ ਹੋਰ ਸਮਰਪਿਤ ਿਸੱਖਾਂ ਦੁਆਰਾ ਵੀ ਮਦਦ ਕੀਤੀ ਗਈ।ਿਹੰਦੂ ਮੰਦਰ ਉਸਾਰੀ ਕਲਾ ਅਨੁਸਾਰ ਉਸਾਰੀ ਨੂੰ ਜ਼ਮੀਨ ਤੋਂ ਉੱਚਾ ਉਸਾਰਣ ਦੀ ਰੀਤ ਤੋਂ ਵੱਖਰਾ ਰਸਤਾ ਅਪਨਾਉਿਂਦਆਂ ਗੁਰੂ ਅਰਜਨ ਸਾਿਹਬ  ਨੇ ਇਸਨੂੰ ਹੇਠਲੀ ਸਤਹ ‘ਤੇ ਰੱਖਕੇ ਬਣਾਇਆ। ਿਹੰਦੂ ਮੰਦਰਾਂ ਅੰਦਰ ਆਉਣ-ਜਾਣ ਵਾਸਤੇ ਿਜਥੇ ਇਕੋ ਦਰਵਾਜ਼ਾ ਹੁੰਦਾ ਹੈ, ਉਥੇ ਗੁਰੂ ਸਾਿਹਬਾਨ ਨੇ ਇਸਨੂੰ ਚਾਰੇ ਪਾਿਸਓ ਖੁੱਲ੍ਾ  ਰੱਿਖਆ। ਇਉਂ ਆਪ ਜੀ ਨੇ ਿਸੱਖ ਧਰਮ ਦਾ ਇਕ ਨਵਾਂ ਿਚੰਨ੍  ਰਚ ਿਦੱਤਾ। ਗੁਰੂ ਸਾਿਹਬ  ਨੇ ਇਸ ਿਵਚ ਜਾਤ, ਨਸਲ, ਿਲੰਗ  ਅਤੇ ਮਜ੍ਹਬ ਦੇ ਿਵਤਕਰੇ ਤੋਂ  ਿਬਨਾਂ ਹਰੇਕ ਮਨੁੱਖ ਦੇ ਦਾਖਲ ਹੋਣ ਵਾਸਤੇ ਿਵਵਸਥਾ ਕੀਤੀ।ਭਵਨ ਉਸਾਰੀ ਦਾ ਕਾਰਜ ਭਾਦਰੋਂ ਸੁਦੀ 1,1661 ਿਬਕਰਮੀ ਸੰਮਤ (ਅਗਸਤ/ਸਤੰਬਰ, 1604) ‘ਚ ਪੂਰਾ ਹੋਇਆ। ਗੁਰੂ ਅਰਜਨ ਸਾਿਹਬ  ਨੇ ਗੁਰੂ ਗ੍ੰਥ ਸਾਿਹਬ  ਜੀ ਨੂੰ ਸ੍ੀ ਹਿਰਮੰਦਰ ਸਾਿਹਬ ਦੇ ਅੰਦਰ ਿਬਰਾਜਮਾਨ ਕੀਤਾ ਅਤੇ ਇਸ ਦੇ ਪਿਹਲੇ ਗ੍ੰਥੀ ਹੋਣ ਦਾ ਮਾਣ ਬਾਬਾ ਬੁੱਢਾ ਜੀ ਨੂੰ ਪ੍ਾਪਤ ਹੋਇਆ। ਇਸ ਅਸਥਾਨ ਨੇ ਅਠਸਠ ਤੀਰਥ ਦਾ ਰੁਤਬਾ ਹਾਸਲ ਕੀਤਾ।");

		baba_budha_ber.set_loc ("baba budha ber");
		baba_budha_ber.set_eng ("Ber Baba Budha Ji:  Baba Budha Jee, the first head priest of Harmandir Sahib, used to sit under this Ber (tree) and supervise the excavation of Amrit Sarovar and construction of Harmandir Sahib. Baba Budha Ji lived for 125 years. He had the honour of coronation of Guru Angad Sahib to Guru Hargobind. The name 'Boorah' (Budha) was in-fact given to him by Guru Nanak Dev Ji (The first Sikh Master) during his first meeting, as a child Budha.This Beri (tree) is more than 500 years old.");
		baba_budha_ber.set_punj ("ਬਾਬਾ ਬੁੱਢਾ ਜੀ ਇਸ ਬੇਰ ਥੱਲੇ ਡੇਰਾ ਲਾ ਕੇ ਪਿਵੱਤਰ ਸਰੋਵਰ ਦੀ ਖੁਦਾਈ ਅਤੇ ਸ੍ੀ ਹਿਰਮੰਦਰ ਸਾਿਹਬ ਦਾ ਕਾਰਜ ਕਰਾਉਂਦੇ ਹੁੰਦੇ ਸਨ। ਸੰਨ 1506 ਿਵਚ ਅੰਿਮ੍ਤਸਰ  ਿਜ਼ਲ੍ੇ ਦੇ  ਿਪੰਡ ਕੱਥੂਨੰਗਲ ਿਵਚ ਜਨਮ ਲੈਣ ਵਾਲੇ, ਿਪਤਾ ਭਾਈ ਸੁੱਘਾ ਰੰਧਾਵਾ ਜੀ ਅਤੇ ਮਾਤਾ ਗੌਰਾਂ ਜੀ ਦੇ ਸਪੁੱਤਰ ਬੂੜੇ ਨੂੰ ਗੁਰੂ ਨਾਨਕ ਪਾਤਸ਼ਾਹ ਨੇ ਕਰਤਾਰਪੁਰੋਂ ਮੁੜਦੇ ਵਕਤ ਿਪੰਡ ਰਮਦਾਸ ਦੀ ਜੂਹ ‘ਚ ਦਰਸ਼ਨ ਿਦੱਤੇ  ਅਤੇ ਬਾਲ ਬੂੜੇ ਨੇ ਗੁਰੂ ਜੀ ਨੂੰ ਵੱਡੀ ਿਨਮਰਤਾ ਦੇ ਭਾਵ ‘ਚ ਦੁੱਧ ਭੇਟ ਕੀਤਾ ਅਤੇ ਗੁਰੂ ਜੀ ਦੀ ਬਾਲਕ ਨਾਲ ਿਵਚਾਰ ਗੋਸ਼ਟੀ ਵੀ ਹੋਈ। ਬਾਲਕ ਵੱਲੋਂ ਛੋਟੀ ਉਮਰ ‘ਚ ਸੁਘੜਤਾ ਦਰਸਾਉਣ ਕਾਰਨ ਉਸਨੂੰ ‘ਬਾਬਾ ਬੁੱਢਾ’ ਦਾ ਰੁਤਬਾ ਹਾਸਲ ਹੋਇਆ। ਜਦੋਂ ਸੰਨ 1604 ਿਵਚ ਪੰਚਮ ਪਾਤਸ਼ਾਹ, ਗੁਰੂ ਅਰਜਨ ਦੇਵ ਜੀ ਨੇ ਸ੍ੀ ਹਿਰਮੰਦਰ ਸਾਿਹਬ ‘ਚ ਗੁਰੂ ਗ੍ੰਥ ਸਾਿਹਬ  ਜੀ ਦੀ ਆਿਦ ਬੀੜ ਦਾ ਪਿਹਲੀ ਵਾਰ ਪ੍ਰਕਾਸ਼ ਕੀਤਾ ਤਾਂ ਬਾਬਾ ਬੁੱਢਾ ਜੀ ਨੂੰ ਇਸ ਦੇ ਪਿਹਲੇ ਗ੍ੰਥੀ ਿਨਯੁਕਤ ਕੀਤਾ। ਦੂਸਰੇ ਗੁਰੂ ਜੀ ਤੋਂ ਲੈ ਕੇ ਛੇਵੇਂ ਗੁਰੂ ਜੀ ਤਕ, ਸਭ ਨੂੰ ਆਪ ਨੇ ਹੀ ਪਾਵਨ ਗੱਦੀ ‘ਤੇ ਿਬਰਾਜਮਾਨ ਕਰਨ ਦੀ ਮਿਰਆਦਾ ਿਨਭਾਈ। ਬਾਬਾ ਜੀ ਨੇ 1631 ਈ: ਿਵਚ 125 ਸਾਲ ਦੀ ਉਮਰ ਿਵਚ ਰਮਦਾਸ ਿਵਖੇ ਅਕਾਲ ਚਲਾਣਾ ਕੀਤਾ। ਆਪ ਦੀ ਿਮ੍ਤਕ ਦੇਹ ਦੀਆਂ ਅੰਤਮ ਰਸਮਾਂ ਗੁਰੂ ਹਿਰਗੋਿਬੰਦ ਸਾਿਹਬ  ਨੇ ਆਪ ਿਨਭਾਈਆਂ।");


		akal_takhat.set_loc ("akal takhat");
		akal_takhat.set_eng("Akal Takhat means the Throne of the Immortal and is the highest political institution of the Sikhs. 'Akal' means 'The Timeless One' - another term for God. 'Takhat' means 'throne' in Persian. The Akal Takhat is an impressive building that sits directly in front of the causeway leading to the Golden Temple in Amritsar. The Akal Takhat was founded by Guru Hargobind on June 15, 1606 (now celebrated on 2 July) and was established as the place from which the spiritual and temporal concerns of the Sikh community could be acted upon.It stood as a symbol of political bulwark against the Mughal Emperors in the 17th and 18th century. Various attacks on the Akal Takhat and Harimandir Sahib have been led in past by Ahmed Shah Abdali and Massa Rangar in the 18 century. On June 4, 1984, the Indian Army did more than just damage the outer facade of the Akal Takhat, they destroyed the sancitity of the Akal Takht with tanks and reduced it to rubble, while attempting to take out Sikh militants in a controversial military operation known as Operation Bluestar.It is the most supreme of all the Takhats. There are four other takhats established by the panth (community) during the last century: Keshgarh Sahib (Anandpur)/n Patna Sahib/n Hazur Sahib /n Damdama Sahib/n Guru Hargobind /n/nGuru Hargobind acceded to the Guruship in 1606, after his father’s tragic end. Although he was just eleven years old at the time, Guru Hargobind is believed to have immediately begun the process of militarisation of the Sikh Panth. At the ceremony of ascension, the Guru declared his intentions: on his turban, he would wear the ruler’s aigrette; instead of the ascetics seli, he would wear a swordbelt with two swords symbolizing Miri and Piri, temporal and spiritual authority. Adopting traditional marks of sovereignty, Guru Hargobind asked his Sikhs to donate not cash but horses and arms. He raised a troop of 52 bodyguards, which formed the nucleus of his army. 500 youths came to him for enlistment from the Manjha (the country between the Ravi and Bias), the Doab (between the Bias and Satluj) and the Malwa countries (comprises the portion of the Punjab formed by Patiala, Nabha, Jind, Faridkot, Firzopur and Ludhiana). Guru Hargobind is also credited with developing Gatka, the martial arts of the Sikhs.");
		akal_takhat.set_punj("ਧੰਨ ਧੰਨ ਗੁਰੂ ਰਾਮ ਦਾਸ ਵੱਲੋਂ ਵਰਸੋਈ ਪਾਵਨ, ਪਿਵੱਤਰ, ਇਿਤਹਾਸਕ ਨਗਰੀ ਸ੍ੀ ਅੰਿਮ੍ਤਸਰ ਦੀ ਧਰਤ ਸੁਹਾਵੀ ‘ਤੇ ਸੱਚਖੰਡ ਸ੍ੀ ਹਿਰਮੰਦਰ ਸਾਿਹਬ  ਦੇ ਸਨਮੁਖ ਮੀਰੀ-ਪੀਰੀ ਦੇ ਮਾਲਕ ਸਾਿਹਬ  ਸ੍ੀ ਗੁਰੂ ਹਿਰਗੋਿਬੰਦ ਸਾਿਹਬ  ਜੀ ਵੱਲੋਂ 1606 ਈ: ਿਵਚ ਿਸਰਜਤ, ਸੁਤੰਤਰ ਿਸੱਖ ਸੋਚ ਨੂੰ ਰੂਪਮਾਨ ਕਰਦੀ ਪ੍ਰਭੂਸੱਤਾ ਸੰਪੰਨ ਸੰਸਥਾ ਸ੍ੀ ਅਕਾਲ ਤਖਤ ਸਾਿਹਬ  ਸੁਭਾਇਮਾਨ ਹੈ। ਵੱਡ ਯੋਧੇ ਬਹੁ ਪਰਉਪਕਾਰੀ ਸਿਤਗੁਰੂ, ਸ੍ੀ ਗੁਰੂ ਹਿਰਗੋਿਬੰਦ ਸਾਿਹਬ  ਵੱਲੋਂ ਿਸਰਜਤ ਸ੍ੀ ਅਕਾਲ ਤਖ਼ਤ ਸਾਿਹਬ  ਿਸੱਖ ਪੰਥ ਦੀ ਸ਼ਕਤੀ ਦਾ ਸਿਰਮੌਰ ਕੇਂਦਰ ਹੈ, ਿਜਸਦੀ ਉਸਾਰੀ ਿਵੱਚ “ਿਕਸੀ ਰਾਜ ਨਿਹ ਹਾਥ ਲਗਾਇਉ-ਬੁਢੇ ਓ ਗੁਰਦਾਸ ਬਨਾਇਓ” ਦੇ ਪਾਵਨ ਵਾਕ ਅਨੁਸਾਰ ਬਾਬਾ ਬੁੱਢਾ ਜੀ ਅਤੇ ਭਾਈ ਗੁਰਦਾਸ ਜੀ ਨੇ ਹੀ ਆਪਣੇ ਕਰ ਕਮਲਾਂ ਨਾਲ ਉਸਾਰੀ ਕੀਤੀ। ਰਾਜਨੀਤੀ ਤੇ ਧਰਮ, ਿਜਸਨੂੰ ਿਸੱਖ ਸ਼ਬਦਾਵਲੀ ਿਵੱਚ ਮੀਰੀ-ਪੀਰੀ, ਭਗਤੀ-ਸ਼ਕਤੀ ਦਾ ਨਾਮ ਿਦੱਤਾ ਿਗਆ ਹੈ, ਦੇ ਦੈਵੀ ਸੁਮੇਲ ਦਾ ਪ੍ਤੀਕ ਹੈ ਸ੍ੀ ਅਕਾਲ ਤਖ਼ਤ ਸਾਿਹਬ । ਸ੍ੀ ਅਕਾਲ ਤਖ਼ਤ ਸਾਿਹਬ  ਮਨੁੱਖੀ ਸਵੈਮਾਣ ਤੇ ਅਜ਼ਾਦੀ ਦੇ ਮੌਲਿਕ ਗੁਰਮਿਤ  ਿਵਚਾਰਾਂ ਅਤੇ ਿਨਰੈਭਤਾ ਦਾ ਜਜ਼ਬਾ ਲੋਕਾਈ ਿਵਚ ਉਜਾਗਰ ਕਰਨ ਲਈ ‘ਹਿਰ ਸਚੇ’ ਨੇ ਇਹ ਦੈਵੀ ਸੱਚੇ ਤਖ਼ਤ ਦੀ ਸਥਾਪਨਾ ਕੀਤੀ ਤਾਂ ਜੋ ਕੋਈ ਮਨੁੱਖ ਿਕਸੇ ਮਨੁੱਖ ਨੂੰ, ਕੋਈ ਜਾਤ ਿਕਸੇ ਜਾਤ ਨੂੰ, ਕੋਈ ਮਜ਼ਹਬ ਿਕਸੇ ਮਜ਼ਹਬ ਨੂੰ, ਕੋਈ ਦੇਸ਼ ਿਕਸੇ ਦੇਸ਼ ਨੂੰ ਆਪਣਾ ਦੁਬੇਲ ਨਾ ਬਣਾ ਸਕੇ ਅਤੇ ਹਰੇਕ ਨੂੰ ਆਪਣੀ ਿਵਚਾਰਧਾਰਾ ਅਨੁਸਾਰ ਜੀਵਨ ਜੀਉਣ ਦਾ ਹੱਕ ਸੁਤੰਤਰ ਬਣਾਇਆ ਜਾ ਸਕੇ। ਇਸ ਪਾਵਨ ਸਥਾਨ ਤੋਂ ਗੁਰਿਸੱਖਾਂ ਨੂੰ ਸ਼ਸਤਰ ਬੱਧ ਹੋਣ, ਗੁਰੂ ਦਰਬਾਰ ਿਵਚ ਵਧੀਆ ਸ਼ਸਤਰ ਤੇ ਜੁਆਨੀਆਂ ਭੇਂਟ ਕਰਨ ਦਾ ਪਿਹਲਾ ਹੁਕਮਨਾਮਾ ਜਾਰੀ ਹੋਇਆ, ਸੰਿਧਆ ਸਮੇਂ ਬੀਰਰਸੀ ਵਾਰਾਂ ਦਾ ਗਇਨ ਕਰਵਾਇਆ ਜਾਂਦਾ ਤਾਂ ਜੋ ਕੌਮ ਿਵਚ ਜਬਰ-ਜ਼ੁਲਮ ਦੇ  ਿਵਰੁੱਧ ਲੜਨ ਲਈ ਜੋਸ਼ ਪੈਦਾ ਹੋ ਸਕੇ। ਿਸੱਖ, ਮੁਗਲ ਅਤੇ ਅਫਗਾਨ ਸੰਘਰਸ਼ ਕਾਲ ਦੌਰਾਨ ਗੁਰਿਸੱਖ ਸ੍ੀ ਅਕਾਲ ਤਖਤ ਸਾਿਹਬ  ਤੋਂ ਪ੍ਰੇਰਨਾ, ਉਤਸ਼ਾਹ ਅਤੇ ਅਗਵਾਈ ਪ੍ਾਪਤ ਕਰਦੇ ਰਹੇ। ਹੰਨੇ-ਹੰਨੇ ਦੀ ਮੀਰੀ ਨੂੰ ਸ੍ੀ ਅਕਾਲ ਤਖਤ ਸਾਿਹਬ  ਨੇ ਹਮੇਸ਼ਾ ਇੱਕਸੁਰਤਾ ਅਤੇ ਇੱਕਸਾਰਤਾ ਬਖਸ਼ੀ। ਇਤਿਹਾਸ ਸਾਖੀ ਹੈ ਿਕ ਉਪਰੋਕਤ ਮੰਤਵਾਂ ਦੀ ਪੂਰਤੀ ਲਈ ਸ੍ੀ ਅਕਾਲ ਤਖ਼ਤ ਸਾਿਹਬ  ਦੀ ਅਗਵਾਈ ਿਵਚ ਆਰੰਭ ਹੋਈ ਜਦੋ ਜਹਿਦ ਨਿਰੰਤਰ ਜਾਰੀ ਹੈ। ਜਦੋਂ ਜਦੋਂ ਵੀ ਮਨੁੱਖੀ ਅਜ਼ਾਦੀ ਤੇ ਸਵੈ-ਮਾਣ ਖਤਰੇ ਿਵੱਚ ਪਏ ਤਾਂ ਸੱਚੇ ਧਰਮ ਦਾ ਜ਼ਜ਼ਬਾ ਲੈ ਕੇ ਉਸਦੀ ਰਾਖੀ ਲਈ ‘ਗੁਰੂ ਕੇ ਿਸੱਖਾਂ’ ਨੇ ਸਦਾ ਪ੍ਰੇਰਣਾ-ਅਗਵਾਈ ਇਥੋਂ ਪ੍ਾਪਤ ਕੀਤੀ। ‘ਖ਼ਾਲਸਾ ਜੀ ਕੇ ਬੋਲਬਾਲੇ ਤੇ ਰਾਜ ਕਰੇਗਾ ਖਾਲਸਾ’ ਦੇ ਬਿੋਲਆ ਦੀ ਗੂੰਜ ਵੀ ਇਥੋਂ ਹੀ ਪੈਂਦੀ ਹੈ। ਸਮੇਂ ਦੀਆਂ ਸਰਕਾਰਾਂ ਇਸ ਅਵਾਜ਼ ਤੋਂ ਹਮੇਸ਼ਾਂ ਡਰਦੀਆਂ ਤੇ ਤ੍ਰੱਬਕਦੀਆਂ ਰਹੀਆਂ। ਇਸੇ ਕਰਕੇ ਹੀ ਸ੍ੀ ਅਕਾਲ ਤਖ਼ਤ ਸਾਿਹਬ  ਦੀ ਇਮਾਰਤ, ਆਦਰਸ਼ਾਂ, ਜਜ਼ਬਿਆਂ ਨੂੰ ਕੁਚਲਣ ਲਈ ਹਰ ਹਰਬਾ ਵਰਤਿਆ ਿਗਆ ਪਰ ਸਮੇਂ ਦੀਆਂ ਸਰਕਾਰਾਂ  ਿਮਟ ਜਾਂਦੀਆਂ ਰਹੀਆਂ ਅਤੇ ਸ੍ੀ ਅਕਾਲ ਤਖ਼ਤ ਸਾਿਹਬ  ‘ਤੇ ਕੇਸਰੀ ਪਰਚਮ ਝੂਲਦੇ ਰਹੇ। , 84 ਦੇ ਘੱਲੂਘਾਰੇ ਦੌਰਾਨ ਸਮੇਂ ਦੀ ਜਾਬਰ ਸਰਕਾਰ ਨੇ ਇਸ ਪਵਨ ਅਸਥਾਨ ਦੀ ਪਾਵਨ ਪਿਵੱਤਰ ਇਤਿਹਾਸਿਕ ਇਮਾਰਤ ਨੂੰ ਬੁਰੀ ਤਰ੍ਹਾਂ ਤਿਹਸ ਨਿਹਸ ਕਰ ਿਦੱਤਾ, ਤਾਂ ਿਕ ਸੁਤੰਤਰ ਿਸੱਖ ਸੋਚ ਦੇ ਪ੍ਰੇਰਨਾ ਸਰੋਤ ਦੀ ਹੋਂਦ ਹਸਤੀ ਖਤਮ ਹੋ ਸਕੇ। ਹਮਲਾਵਰਾਂ ਦੀ ਹੋਂਦ ਹਸਤੀ ਤਾਂ ਖਤਮ ਹੋ ਗਈ ਪਰ ਭਗਤੀ-ਸ਼ਕਤੀ ਦਾ ਕੇਂਦਰੀ ਅਸਥਾਨ ਹਮੇਸ਼ਾਂ ਗੁਰਿਸੱਖਾਂ ਲਈ ਪ੍ਰੇਰਨਾ, ਸ਼ਕਤੀ ਤੇ ਉਤਸ਼ਾਹ ਪ੍ਾਪਤ ਕਰਦਾ ਰਹੇਗਾ। ‘ਜਹਾਂ ਜਹਾਂ ਖਾਲਸਾ ਜੀ ਸਾਿਹਬ , ਤਹਾਂ ਤਹਾਂ  ਰੱਿਛਆ ਿਰਆਇਤ’ ਅਤੇ ਪੰਥ ਦੀ ਚੜ੍ਹਦੀ ਕਲਾ, ਹਰ ਰੋਜ਼ ਹਰ ਗੁਰਿਸੱਖ ਮੰਗਦਾ ਹੈ। ਉਸ ਦਾ ਜ਼ਾਮਨ ਵੀ ਸ੍ੀ ਅਕਾਲ ਤਖ਼ਤ ਹੀ ਹੈ। ਇਸ ਕਰਕੇ ਸ੍ੀ ਅਕਾਲ ਤਖ਼ਤ ਸਾਿਹਬ  ਤੋਂ ਜਾਰੀ ਹਰ ਹੁਕਮ ਨੂੰ ਰਾਜਾ-ਰੰਕ, ਅਮੀਰ-ਗਰੀਬ, ਹਰ ਗੁਰਿਸੱਖ, ਗੁਰੂ-ਪੰਥ ਦਾ ਹੁਕਮ ਜਾਣ ਸੀਸ ਝੁਕਾ, ਪ੍ਰਵਾਨ ਚੜ੍ਹਾਉਂਦਾ ਹੋਇਆ, ਗੁਰੂ ਪਾਤਸ਼ਾਹ ਦੀਆਂ ਖੁਸ਼ੀਆਂ ਪ੍ਾਪਤ ਕਰਦਾ ਹੈ।");


		dukh_bhanjan.set_loc ("Dukh Bhanjani Beer Sahib");
		dukh_bhanjan.set_eng ("Duni Chand Khatri was a rich land lord of Patti town. He had five daughters. All were beautiful and talented. One day Duni Chand asked his daughters,'Tell me who provides you meals' Elder four daughter readily said that their father was providing them every thing. He is their benefactor.But the younger daughter named, Rajni replied, 'It is God that sustains all living beings' Hearing this reply Duni Chand was so enraged that he married Rajni to a leper. But Rajni did not care about it. She accepted the leper as her husband and served him with great love.In those days Guru Ram Das Ji was constructing a new city at Amritsar.Rajni took the leper with him and reached Amritsar. She met the devotees of the Guru When devotees saw that her husband was leper they took pity on her and provided him a room to live. She also joined the other devotees and was deputed to cook meals in the common kitchen. She was well contented with her fate. She was always contemplating the name of God. When she was going to join his duty, she used to take her husband with her.\nMaking a suitable arrangement for his sitting under a shady tree, she used to go to the kitchen. One day she left him to sit under a Ber tree. When her husband the leper was sitting on the bank of the pond, he saw a pair of crows dipped down in the pool and flew away with their colour changing from black to white. Seeingthis he concluded that pool did not contain an ordinary water, so he made up his mind to bathe in the tank. He reached near the pond and dipped into the water.A miracle happens?\n\n\nDukh Bhanjani Beri in 1884\nWhen he came out he was astonished to see himself hale and healthy, He was no longer a leper. He walked as a youngman and again sat under the shade of the Ber tree. When Rajni returned from langar she was unable to recognize him. When the youngman convinced him her telling her the whole story; Rajni felt very happy. They met Guru Ram Dass Ji and told him the whole story The Guru was pleased to hear it. He told Baba Budha Ji that pond was the same haly place about which Gum Amar Dass Ji had foretold. When the people of the area heard about the appearance of Netar pond they rushed to see and have a bath in it The tree under which the leper was sitting came to be known as Dukh bhanjani Beri as it relieves the pains and afflictions A Gurdwara has been built near that Bed and thousands of people take bath near that Beri");
		dukh_bhanjan.set_punj("ਸ੍ੀ ਦੁਖ ਭੰਜਨੀ ਬੇਰੀ ਦੁਖ ਭੰਜਨੀ ਬੇਰੀ ਦੁਨੀ ਚੰਦ ਖੱਤਰੀ ਪੱਟੀ ਸ਼ਹਿਰ ਦੇ ਇੱਕ ਅਮੀਰ ਜ਼ਮੀਨ ਮਾਲਕ ਸੀ. ਉਸ ਨੇ ਪੰਜ ਖਾਨਦਾਨ ਸੀ. ਸਾਰੇ ਸੁੰਦਰ ਅਤੇ ਪ੍ਿਤਭਾਸ਼ਾਲੀ ਸਨ. ਇਕ ਿਦਨ ਦੁਨੀ ਚੰਦ ਨੇ ਆਪਣੇ ਖਾਨਦਾਨ ਨੂੰ ਪੁਿੱਛਆ,'ਮੈਨੂੰ ਦੱਸ ਜੋ ਤੁਹਾਨੂੰ ਭੋਜਨ ਿਦੰਦਾ ਹੈ' ਬਜ਼ੁਰਗ ਨੇ ਚਾਰ ਧੀ ਨੂੰ ਆਸਾਨੀ ਨਾਲ ਿਕਹਾ ਹੈ ਿਕ ਉਹ ਆਪਣੇ ਿਪਤਾ ਦੀ ਹਰ ਗੱਲ ਨੂੰ ਮੁਹੱਈਆ ਕੀਤਾ ਿਗਆ ਹੈ. ਉਸ ਨੇ ਆਪਣੇ ਿਹਤਕਾਰੀ ਹੈ.ਪਰ ਛੋਟੀ ਧੀ ਦਾ ਨਾਮ, ਰਜਨੀ ਨੇ ਜਵਾਬ ਿਦੱਤਾ,'ਪਰਮਾਤਮਾ' ,ਇਸ ਜਵਾਬ ਤੇ ਦੁਨੀ ਚੰਦ, ਇਸ ਲਈ ਗੁੱਸੇ ਸੀ ਿਕ ਉਸ ਨੇ ਇੱਕ ਕੋੜ੍ਹੀ ਨੂੰ ਰਜਨੀ ਦੇ ਵਿਆਹ ਿਦੱਤਾ  ਸੀ,  ਪਰ ਰਜਨੀ ਨੇ ਇਸ ਬਾਰੇ ਪਰਵਾਹ ਨਾ ਸੀ. ਉਹ ਆਪਣੇ ਪਤੀ ਦੇ ਰੂਪ ਿਵੱਚ ਕੋੜ੍ਹੀ ਨੂੰ ਸਵੀਕਾਰ ਕਰਨ ਕੀਤਾ ਅਤੇ ਉਸ ਨੂੰ ਬਹੁਤ  ਿਪਆਰ ਨਾਲ ਸੇਵਾ ਕੀਤੀ ਉਹ ਿਦਨ ਗੁਰੂ ਰਾਮ ਦਾਸ ਜੀ 'ਤੇ ਇੱਕ ਨਵ ਸ਼ਹਿਰ ਦਾ ਿਨਰਮਾਣ ਕੀਤਾ ਿਗਆ ਸੀ ਅਿੰਮ੍ਤਸਰ ");


		//----------External
		santokhsar_sahib.set_loc ("Santokhsar Sahib");
		santokhsar_sahib.set_eng ("Gurdwara Santokhsar Sahib is an historical sikh shrine, situated at distance of 700 Meters from Harimandir Sahib. This is one of the five historical sarovers constructed by Guru Arjun Dev.When Guru Ram Das, had not yet ascended to the gaddi, he came here to find out a place for excavation of the holy tank on instructions from Guru Amar Das. When Guru Ram Das was getting the place dug, he found a Yogi, meditating.After sometime the Yogi opened his eyes and told Guru Ram Das that he had been meditating here for a long time, waiting for a Guru to give him salvation. He disclosed his name as Santakha and then breathed his last. The tank was then named as Santokhsar.Guru Arjan completed the unfinished work of excavation of tanks - Santokhsar and Amritsar. Baba Buddha was appointed to supervise the work of construction. Santokhsar was completed in 1587-89.");
		santokhsar_sahib.set_punj ("ਗੁਰਦੁਆਰਾ ਸ੍ੀ ਸੰਤੋਖਸਰ ਸਾਿਹਬ ਇੱਕ ਇਤਹਾਿਸਕ ਗੁਰਦੁਆਰਾ,ਹਿਰਮੰਦਰ ਸਾਿਹਬ 700 ਮੀਟਰ ਦੀ ਦੂਰੀ 'ਤੇ ਸਿਥਤ ਹੈ. ਇਹ ਪੰਜ ਇਤਹਾਿਸਕ ਗੁਰੂ ਅਰਜਨ ਦੇਵ ਦਾ ਬਣਾਇਆ ਸਰੋਵਰ ਦੇ ਇੱਕ ਹੈ.ਜਦ ਗੁਰੂ ਰਾਮ ਦਾਸ ਚੁਬੱਚਾ ਕਿਢਆ ਰਹੀ ਸੀ, ਇੱਕ ਯੋਗੀ ਨੂੰ ਿਮਿਲਆ, ਿਸਮਰਨ ਕਰਨ.ਕੁਝ ਦੇ ਬਾਅਦ ਯੋਗੀ ਉਸ ਦੀ ਿਨਗਾਹ ਖੋਿਲ੍ਆ ਅਤੇ ਗੁਰੂ ਰਾਮ ਦਾਸ ਨੇ ਦੱਿਸਆ ਿਕ ਉਸ ਨੇ ਇੱਥੇ ਇੱਕ ਲੰਮੇ ਸਮ ਲਈ ਸੋਚ-ਿਵਚਾਰ ਕੀਤਾ ਿਗਆ ਸੀ, ਨੂੰ ਇੱਕ ਗੁਰੂ ਦੀ ਉਡੀਕ ਕਰ ਉਸ ਨੂੰ ਮੁਕਤੀ ਦਾਨ ਦੇਣ ਲਈ. ਉਸ ਨੇ  'ਸੰਤੋਖਸਰ ' ਦੇ ਤੌਰ ਤੇ ਉਸ ਦਾ ਨਾਮ ਦਾ ਖੁਲਾਸਾ ਕਰਨ ਅਤੇ ਿਫਰ ਉਸ ਦੇ ਆਖਰੀ ਸਾਹ ਿਲਆ. ਸਰੋਵਰ ਿਫਰ ਸੰਤੋਖਸਰ ਦੇ ਤੌਰ ਤੇ ਬਣਾਇਆ ਿਗਆ ਹੈ.\n\nਸੰਤੋਖਸਰ ਅਤੇ ਅੰਿਮ੍ਤਸਰ - ਗੁਰੂ ਅਰਜਨ ਦੇਵ ਨੇ ਕੁੰਡ ਦੀ ਖੁਦਾਈ ਦੇ ਅਧੂਰੇ ਕੰਮ ਨੂੰ ਪੂਰਾ ਕੀਤਾ. ਬਾਬਾ ਬੁੱਢਾ ਉਸਾਰੀ ਦੇ ਕੰਮ ਦੀ ਿਨਗਰਾਨੀ ਕਰਨ ਲਈ ਿਨਯੁਕਤ ਕੀਤਾ ਿਗਆ ਸੀ. ਸੰਤੋਖਸਰ 1587-89 ਿਵਚ ਮੁਕੰਮਲ ਕੀਤਾ ਿਗਆ ਸੀ.\n");
	
		DRABBEDKAR.set_loc ("Dr. B.R Ambedkar");
		DRABBEDKAR.set_eng ("DR. B.R. Ambedkar(Indian jurist)\nBhimrao Ramji Ambedkar, popularly known as Baba Saheb, was an Indian jurist, economist, politician and social reformer who inspired the Dalit Buddhist Movement and campaigned against social discrimination\n\nBorn: 14 April 1891, Mhow\nDied: 6 December 1956, Delhi\nEducation: London School of Economics and Political Science (1916–1922).\n\nQuotes\n\nThe relationship between husband and wife should be one of closest friends.\nI measure the progress of a community by the degree of progress which women have achieved.\nLife should be great rather than long.");
		DRABBEDKAR.set_punj ("ਡਾਕਟਰ ਭੀਮ ਰਾਉ ਅੰਬੇਡਕਰ (14 ਅਪ੍ਰੈਲ 1891 - 6 ਦਸੰਬਰ 1956) ਇੱਕ ਭਾਰਤੀ ਕਾਨੂੰਨਸਾਜ਼ ਸਨ। ਉਹ ਇੱਕ ਬਹੁਜਨ ਰਾਜਨੀਤਕ ਨੇਤਾ ਅਤੇ ਬੋਧੀ ਪੁਨਰੁੱਥਾਨਵਾਦੀ ਹੋਣ ਦੇ ਨਾਲ ਨਾਲ ਭਾਰਤੀ ਸੰਵਿਧਾਨ ਦੇ ਮੁੱਖ ਨਿਰਮਾਤਾ ਵੀ ਸਨ। [1] ਉਨ੍ਹਾਂ ਨੂੰ ਬਾਬਾ ਸਾਹਿਬ ਦੇ ਨਾਮ ਨਾਲ ਵੀ ਜਾਣਿਆ ਜਾਂਦਾ ਹੈ। ਉਨ੍ਹਾਂ ਦਾ ਜਨਮ ਇੱਕ ਗਰੀਬ ਅਛੂਤ ਪਰਵਾਰ ਵਿੱਚ ਹੋਇਆ ਸੀ। ਬਾਬਾ ਸਾਹਿਬ ਅੰਬੇਡਕਰ ਨੇ ਆਪਣਾ ਸਾਰਾ ਜੀਵਨ ਹਿੰਦੂ ਧਰਮ ਦੀ ਚਾਰ ਵਰਣ ਪ੍ਰਣਾਲੀ, ਅਤੇ ਭਾਰਤੀ ਸਮਾਜ ਵਿੱਚ ਸਰਵਵਿਆਪਤ ਜਾਤੀ ਵਿਵਸਥਾ ਦੇ ਵਿਰੁੱਧ ਸੰਘਰਸ਼ ਵਿੱਚ ਬਿਤਾ ਦਿੱਤਾ। ਹਿੰਦੂ ਧਰਮ ਵਿੱਚ ਮਨੁੱਖੀ ਸਮਾਜ ਨੂੰ ਚਾਰ ਵਰਣਾਂ ਵਿੱਚ ਵਰਗੀਕ੍ਰਿਤ ਕੀਤਾ ਹੈ। ਉਨ੍ਹਾਂ ਨੂੰ ਬੋਧੀ ਮਹਾਸ਼ਕਤੀਆਂ ਦੇ ਦਲਿਤ ਅੰਦੋਲਨ ਨੂੰ ਅਰੰਭ ਕਰਨ ਦਾ ਸਿਹਰਾ ਵੀ ਜਾਂਦਾ ਹੈ। ਬਾਬਾ ਸਾਹਿਬ ਅੰਬੇਡਕਰ ਨੂੰ ਭਾਰਤ ਦੇ ਸਰਬਉਚ ਨਾਗਰਿਕ ਇਨਾਮ ਭਾਰਤ ਰਤਨ ਨਾਲ ਵੀ ਸਨਮਾਨਿਤ ਕੀਤਾ ਗਿਆ ਹੈ।\n\nਕਈ ਸਾਮਾਜਕ ਅਤੇ ਵਿੱਤੀ ਰੁਕਾਵਟਾਂ ਪਾਰ ਕਰ, ਅੰਬੇਡਕਰ ਉਨ੍ਹਾਂ ਕੁੱਝ ਪਹਿਲੇ ਅਛੂਤਾਂ ਵਿੱਚੋਂ ਇੱਕ ਬਣ ਗਏ ਜਿਨ੍ਹਾਂ ਨੇ ਭਾਰਤ ਵਿੱਚ ਕਾਲਜ ਦੀ ਸਿੱਖਿਆ ਪ੍ਰਾਪਤ ਕੀਤੀ। ਅੰਬੇਡਕਰ ਨੇ ਕਨੂੰਨ ਦੀ ਉਪਾਧੀ ਪ੍ਰਾਪਤ ਕਰਨ ਦੇ ਨਾਲ ਹੀ ਕਾਨੂੰਨ, ਅਰਥ ਸ਼ਾਸਤਰ ਅਤੇ ਰਾਜਨੀਤਕ ਵਿਗਿਆਨ ਵਿੱਚ ਆਪਣੇ ਅਧਿਅਨ ਅਤੇ ਅਨੁਸੰਧਾਨ ਦੇ ਕਾਰਨ ਕੋਲੰਬੀਆ ਯੂਨੀਵਰਸਿਟੀ ਅਤੇ ਲੰਡਨ ਸਕੂਲ ਆਫ ਇਕਾਨਾਮਿਕਸ ਤੋਂ ਕਈ ਡਾਕਟਰੇਟ ਡਿਗਰੀਆਂ ਵੀ ਹਾਸਲ ਕੀਤੀਆਂ। ਅੰਬੇਡਕਰ ਇੱਕ ਪ੍ਰਸਿੱਧ ਵਿਦਵਾਨ ਦੇ ਰੂਪ ਵਿੱਚ ਵਾਪਸ ਆਪਣੇ ਦੇਸ਼ ਪਰਤ ਆਏ ਅਤੇ ਇਸਦੇ ਬਾਅਦ ਕੁੱਝ ਸਾਲ ਤੱਕ ਉਨ੍ਹਾਂ ਨੇ ਵਕਾਲਤ ਕੀਤੀ। ਫਿਰ ਉਨ੍ਹਾਂ ਨੇ ਕੁੱਝ ਪੱਤਰਕਾਵਾਂ ਦਾ ਪ੍ਰਕਾਸ਼ਨ ਕੀਤਾ, ਜਿਨ੍ਹਾਂ ਦੁਆਰਾ ਉਨ੍ਹਾਂ ਨੇ ਭਾਰਤੀ ਅਛੂਤਾਂ ਦੇ ਰਾਜਨੀਤਕ ਅਧਿਕਾਰਾਂ ਅਤੇ ਸਾਮਾਜਕ ਆਜ਼ਾਦੀ ਦੀ ਵਕਾਲਤ ਕੀਤੀ। ਡਾ. ਅੰਬੇਡਕਰ ਨੂੰ ਭਾਰਤੀ ਬੋਧੀ ਭਿੱਕੂ ਨੇ ਬੋਧੀਸਤਵ ਦੀ ਉਪਾਧੀ ਪ੍ਰਦਾਨ ਕੀਤੀ ਹੈ");

        maharja_ranjit_singh.set_loc ("Maharja Ranjit Singh");
		maharja_ranjit_singh.set_eng ("Ranjit Singh Former Maharaja\nMaharaja Ranjit Singh, was the leader of the Sikh Empire, which ruled the northwest Indian subcontinent in the early half of the 19th century. He survived smallpox in infancy but lost sight in his left eye.\nBorn: 13 November 1780, Gujranwala, Pakistan\nDied: 27 June 1839, Lahore, Pakistan\nSpouse: Jind Kaur (m. 1835), Datar Kaur (m. 1798)\nChildren: Duleep Singh, Sher Singh, Kharak Singh, Kashmira Singh, Pashaura Singh, Multana Singh, Ishar Singh, Tara Singh\nGrandchildren: Nau Nihal Singh, Sophia Duleep Singh, MORE\nParents: Maha Singh, Raj Kaur ");
		maharja_ranjit_singh.set_punj ("ਮਹਾਰਾਜਾ ਰਣਜੀਤ ਸਿੰਘ (1780-1839) ਪੰਜਾਬ ਦੀ ਸਿੱਖ ਸਲਤਨਤ ਦੀ ਨੀਂਹ ਰੱਖਣ ਵਾਲ਼ਾ ਇੱਕ ਸਿੱਖ ਮਹਾਰਾਜਾ ਸੀ ਜੋ ਸ਼ੇਰ-ਏ-ਪੰਜਾਬ (ਪੰਜਾਬ ਦਾ ਸ਼ੇਰ) ਦੇ ਨਾਂ ਨਾਲ਼ ਜਾਣਿਆ ਜਾਂਦਾ ਹੈ। ਮਹਾਰਾਜਾ ਰਣਜੀਤ ਸਿੰਘ ਨੂੰ ਪੰਜਾਬ ਦੇ ਇਤਿਹਾਸ ਵਿੱਚ ਬਹਾਦਰ ਜੰਗਜੂ, ਦਲੇਰ ਮਹਾਰਾਜੇ ਤੇ ਮਹਾਨ ਸ਼ਖ਼ਸੀਅਤ ਵਜੋਂ ਜਾਣਿਆ ਜਾਂਦਾ ਹੈ। ਮਹਾਰਾਜਾ ਰਣਜੀਤ ਸਿੰਘ ਨੇ ਆਪਣੇ ਰਾਜ ਵਿੱਚ ਸਿੱਖਾਂ, ਹਿੰਦੂਆਂ ਤੇ ਮੁਸਲਮਾਨਾਂ ਨੂੰ ਇੱਕ ਡੋਰ ਵਿੱਚ ਪਰੋਈ ਰੱਖਿਆ, ਜਿਸ ਕਰਕੇ ਖ਼ਾਲਸਾ ਰਾਜ ਦੀ ਹਰ ਥਾਂ ਸਿਫ਼ਤ ਕੀਤੀ ਜਾਂਦੀ ਸੀ।\n\nਸਿੰਘ ਦਾ ਪਿਤਾ ਮਹਾਂ ਸਿੰਘ , ਸ਼ੁੱਕਰਚੱਕੀਆ ਮਿਸਲ ਦਾ ਜੱਥੇਦਾਰ ਸੀ ਅਤੇ ਉਸ ਦਾ ਇਲਾਕਾ ਅੱਜ ਦੇ ਲਹਿੰਦੇ ਪੰਜਾਬ ਦੇ ਗੁੱਜਰਾਂਵਾਲੇ ਦੇ ਦੁਆਲੇ ਸੀ। 1792 ਈ: ਵਿੱਚ ਮਹਾਂ ਸਿੰਘ ਦੀ ਮੌਤ ਪਿੱਛੋਂ ਮਿਸਲ ਦਾ ਰਾਜ-ਪ੍ਬੰਧ ਉਸ ਦੀ ਪਤਨੀ ਰਾਜ ਕੌਰ ਦੇ ਹੱਥਾਂ ਵਿੱਚ ਆ ਗਿਆ|ਰਾਜ ਕੌਰ ਇੱਕ ਅਯੋਗ ਤੇ ਕਮਜੋਰ ਇਸਤਰੀ ਸੀ ਅਤੇ ਉਸਨੇ ਸਾਰਾ ਕੰਮ-ਕਾਜ ਸਰਦਾਰ ਲਖਪਤ ਰਾਏ ਦੇ ਹਵਾਲੇ ਕਰ ਦਿੱਤਾ|1796 ਈ: ਵਿੱਚ ਰਣਜੀਤ ਸਿੰਘ ਦਾ ਵਿਆਹ ਮਹਿਤਾਬ ਕੌਰ ਨਾਲ ਹੋ ਜਾਣ ਉਪਰੰਤ ਉਸਦੀ ਸੱਸ ਸਦਾ ਕੌਰ ਵੀ ਸ਼ੁੱਕਰਚੱਕੀਆ ਮਿਸਲ ਦੇ ਸ਼ਾਸਨ-ਪ੍ਬੰਧ ਵਿੱਚ ਹਿੱਸਾ ਲੈਣ ਲੱਗੀ|ਜਦ ਤੱਕ ਰਣਜੀਤ ਸਿੰਘ ਨਾਬਾਲਗ ਰਿਹਾ, ਮਿਸਲ ਦਾ ਰਾਜ-ਪ੍ਬੰਧ ਤਿੰਨ ਵਿਅਕਤੀਆਂ ਦੇ ਹੱਥਾਂ ਵਿੱਚ ਰਿਹਾ—ਰਾਜ ਕੌਰ, ਸਦਾ ਕੌਰ ਤੇ ਦੀਵਾਨ ਲਖਪਤ ਰਾਏ|ਇਸ ਕਾਲ ਨੂੰ ਤਿੱਕੜੀ ਦੀ ਸਰਪ੍ਸਤੀ ਦਾ ਕਾਲ ਕਿਹਾ ਜਾਂਦਾ ਹੈ|1797 ਈ: ਵਿੱਚ ਜਦ ਰਣਜੀਤ ਸਿੰਘ 17 ਵਰਿਆਂ ਦਾ ਹੋ ਗਿਆ ਤਾਂ ਉਸ ਨੇ ਰਾਜ-ਪ੍ਬੰਧ ਦੀ ਵਾਗ-ਡੋਰ ਆਪਣੇ ਹੱਥਾਂ ਵਿੱਚ ਲੈ ਲਈ|\n\nਉਸ ਨੇ ਕਈ ਮੁਹਿੰਮਾਂ ਨਾਲ਼ ਸਿੱਖ ਮਿਸਲਾਂ ਨੂੰ ਇੱਕ ਖੇਤਰ ਦੇ ਰੂਪ ਵਿੱਚ ਇੱਕਠਾ ਕੀਤਾ ਅਤੇ 12 ਅਪਰੈਲ 1801 (ਵਿਸਾਖੀ ਦੇ ਦਿਨ) ਨੂੰ ਮਹਾਰਜੇ ਦੇ ਤਖ਼ਤ-ਨਸ਼ੀਨ ਹੋ ਕੇ ਲਾਹੌਰ ਨੂੰ ਆਪਣੀ ਰਾਜਧਾਨੀ ਬਣਾਇਆ। ਉਸਨੇ ਮੁਲਤਾਨ, ਪੇਸ਼ਾਵਰ, ਜੰਮੂ ਅਤੇ ਕਸ਼ਮੀਰ ਅਤੇ ਆਨੰਦਪੁਰ ਦੇ ਪਹਾੜੀ ਇਲਾਕੇ ਉੱਤੇ ਕਬਜ਼ਾn ਕੀਤਾ ਜਿਸ ਵਿੱਚ ਵੱਡਾ ਇਲਾਕਾ ਕਾਂਗੜਾ ਸੀ। 1802 ਵਿੱਚ ਉਸ ਨੇ ਪਵਿੱਤਰ ਸ਼ਹਿਰ ਅੰਮ੍ਰਿਤਸਰ ਨੂੰ ਆਪਣੇ ਰਾਜ ਵਿੱਚ ਜੋੜ ਲਿਆ ਅਤੇ ਸਿੱਖਾਂ ਦੇ ਪਵਿੱਤਰ ਗੁਰਦੁਆਰੇ,੍ੀ ਹਿਰਮੰਦਰ ਸਾਿਹਬ  ਸਾਿਹਬ, ਦੀ ਸੰਗਮਰਮਰ ਅਤੇ ਸੋਨੇ ਨਾਲ਼ ਸੇਵਾ ਕਰਵਾਈ ਜਿਸ ਕਰਕੇ ਉਸ ਦਾ ਨਾਂ ਸੁਨਹਿਰੀ ਮੰਦਰ (ਅੰਗਰੇਜ਼ੀ: Golden temple) ਪਿਆ।");


        history.Add (baba_budha_ber);
        history.Add (harimandir);
		history.Add (akal_takhat);
		history.Add (santokhsar_sahib);
		history.Add (DRABBEDKAR);
		history.Add (maharja_ranjit_singh);
		history.Add(dukh_bhanjan);
		UnityEngine.Debug.Log ("Done");
		}
}

