using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tranquangtuan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bai 1:\nHello FIT-TDC");
            Console.WriteLine("\nbai2:");
            bai2();
            Console.WriteLine("\nbai3:");
            bai3();
            Console.WriteLine("\nbai 4: ");
            bai4();
            Console.WriteLine("\nbai 5:");
            bai5();
            Console.WriteLine("\nbai 6:");
            bai6();
            Console.WriteLine("\nbai 7:");
            bai7();
            Console.WriteLine("\nbai 8:");
            bai8();
            Console.WriteLine("\nbai 9:");
            bai9();
            Console.WriteLine("\nbai 10:");
            bai10();
            Console.WriteLine("\nbai11:");
            bai11();
            Console.WriteLine("\nbai 12:");
            int iN;
            Console.Write("nhap vao so nguyen: ");
            iN = Convert.ToInt32(Console.ReadLine());
            if (bai12(iN) == 1)
                Console.WriteLine("la so nguyen to!");
            else
                Console.WriteLine("khong phai so nguyen to!");

            Console.WriteLine("\nbai 13:");
            bai13();
            Console.ReadLine();
        }
        static void bai2()
        {
            string sTen;
            Console.Write("nhap vao ten nguoi dung : ");
            sTen=Console.ReadLine();
            Console.WriteLine("chao mung "+ sTen+ " den voi FIT-TDC");
        }
        static void bai3()
        {
            int iA = 100;
            int iB = iA;
            Console.WriteLine("iB= "+ iB);
        }
        static void bai4()
        {
            int iA, iB;
            Console.Write("nhap so thu nhat: ");
            iA = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so thu hai: ");
            iB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong= " + (iA + iB));
            Console.WriteLine("Hieu= " + (iA - iB));
            Console.WriteLine("Tich= " + (iA * iB));
            Console.WriteLine("Thuong= " + (iA / iB));
        }
        static void bai5()
        {
            int iNum1, iNum2;
            Console.Write("nhap vao Num1: ");
            iNum1= Convert.ToInt32(Console.ReadLine()); ;
            Console.Write("nhap vao Num2: ");
            iNum2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gia tri Num1= " + iNum1);
            Console.WriteLine("Gia tri Num2= " + iNum2);
            Console.WriteLine("Num1+Num2= " + (iNum1 + iNum2));
        }
        static void bai6()
        {
            int iN;
            Console.Write("nhap vao so nguyen duong: ");
            iN= Convert.ToInt32(Console.ReadLine());
            if (iN % 2 == 0)
                Console.WriteLine("so chan ne!");
            else
                Console.WriteLine("so le ne!");
        }
        static void bai7()
        {
            int iN;
            Console.Write("nhap vao so nguyen duong num: ");
            iN = Convert.ToInt32(Console.ReadLine());
            if (iN % 2 == 0)
                Console.WriteLine("so chan ne! tang mot don vi: num ="+(iN+1));
            else
                Console.WriteLine("so le ne! giam mot don vi: num = "+(iN-1));
        }
        static void bai8()
        {
            int sale_1, sale_2, commission_rate, total_sale;
            Console.Write("nhap vao sale_1: ");
            sale_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap vao sale_2: ");
            sale_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap vao commission_rate: ");
            commission_rate = Convert.ToInt32(Console.ReadLine());
            total_sale = sale_1 + sale_2;
            commission_rate *= total_sale;
            Console.WriteLine("gia tri commission_rate= " + commission_rate);
        }
        static v.il,escapistmagazine.com,paroles.net,universfreebox.com,sciencealert.com,futura-sciences.com,6fun.fr,abovetopsecret.com,acidcow.com,backpacker.com,nextgen-auto.com,theadvocate.com,theneworleansadvocate.com,algerie-focus.com,architectureartdesigns.com,architecturendesign.net,arsenalrumours.co.uk,artdaily.com,attitude.co.uk,golf.swingbyswing.com,badabun.net,erenumerique.fr,fredzone.org,blacklistednews.com,bloody-disgusting.com,bored.com,boulistenaute.com,bridoz.com,empireofthekop.com,chachanova.com,cityam.com,countercurrentnews.com,dcclothesline.com,deccanchronicle.com,damnyouautocorrect.com,screenjunkies.com,designyoutrust.com,divertissonsnous.com,dogheirs.com,reshareworthy.com,dumpaday.com,easyvoyage.com,easyviaggio.com,egokick.com,topmercato.com,tribune.com.pk,express.pk,faitsdivers.org,tropcute.com,trucsetbricolages.com,veuxturire.com,fastfoodmenuprices.com,financialjuneteenth.com,flickeringmyth.com,hkpro.com,marlinowners.com,sniperforums.com,trapshooters.com,xdtalk.com,freedomoutpost.com,freemake.com,freemalaysiatoday.com,gaytimes.co.uk,gohabsgo.com,news9.com,newson6.com,gulte.com,healthstatus.com,hellawella.com,advocate.com,shewired.com,hitc.com,hollywoodtake.com,homestead-and-survival.com,humourdemecs.com,indiaglitz.com,indiancountrytodaymedianetwork.com,info24.fr,creators.com,headlinepolitics.com,tellmenow.com,inthesetimes.com,jewsnews.com,jewsnews.co.il,debka.com,jewishworldreview.com,truthrevolt.org,freebeacon.com,kraftrecipes.com,famillebonplan.fr,canal-supporters.com,cinetrafic.fr,foot-national.com,lakako.com,laughfactory.com,lensois.com,lewrockwell.com,lightersideofrealestate.com,linformatique.org,lovemeow.com,lucianne.com,anime1.com,drama.net,maplestage.com,thecourier.co.uk,livenewschat.eu,moneyam.com,moneycrashers.com,rockfordmugshots.com,gosocial.co,littlechurchmouse.com,mylol.com,route.newsactus.com,newsoxy.com,notrefamille.com,prenoms.com,Odili.net,onenewspage.com,fourchette-et-bikini.fr,paristeam.fr,planetemercato.fr,mrfood.com,original.antiwar.com,pyzam.com,rap-up.com,familyhandyman.com,reason.com,recreoviral.com,clevescene.com,metrotimes.com,orlandoweekly.com,sacurrent.com,saharareporters.com,godvine.com,sante-nutrition.org,popthatzits.com,sciencebasedmedicine.org,science20.com,sescoops.com,mmanews.com,shareably.net,chicagofootball.com,shtfplan.com,skepchick.org,forzaitalianfootball.com,solveyourtech.com,basketball-reference.com,stripes.com,strongmindbraveheart.com,cyclismactu.net,tacticalshit.com,talkingbaws.com,tamiltvshows.net,team-aaa.com,techpp.com,theamericanconservative.com,themalaymailonline.com,theozone.net,therealdeal.com,theshrug.com,thesmokinggun.com,tigernet.com,football-italia.net,todayifoundout.com,topdocumentaryfilms.com,topgearspecials.com,topibuzz.com,toprightnews.com,tout-bon.com,tunemovie.is,turfomania.fr,turfoo.fr,vancitybuzz.com,viralslot.com,viralvideosgallery.com,vkool.com,prettylittleliars.alloyentertainment.com,webgirondins.com,interestingengineering.com,welldonestuff.com,wonderfulengineering.com,al