using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    // Token: 0x0200000A RID: 10
    public partial class TimeAndDate : Form
    {
        // Token: 0x06000046 RID: 70 RVA: 0x000056DC File Offset: 0x000038DC
        public TimeAndDate(Main mainForm)
        {
            this.InitializeComponent();
            this._mainForm = mainForm;
            this.LoadClockHTML();
            this.FetchAndPopulateTimeZones(this.timeZoneCombo);
            this.monthCalendar1.AutoSize = false;
            this.monthCalendar1.Width = 170;
            this.monthCalendar1.Height = 137;
            this.timeZoneCombo.SelectedIndexChanged += this.TimeZoneCombo_SelectedIndexChanged;
        }

        // Token: 0x06000047 RID: 71 RVA: 0x00005754 File Offset: 0x00003954
        private void LoadClockHTML()
        {
            string documentText = "<!doctype html>\r\n            <!DOCTYPE html> \r\n            <html> \r\n              <head> \r\n                <meta http-equiv='X-UA-Compatible' content='IE=edge'> \r\n             </head>\r\n            <body>\r\n            <div id='clock'>\r\n                <div id='hour'></div>\r\n                <div id='minute'></div>\r\n                <div id='second'></div>\r\n            </div>\r\n            <style>\r\n                #clock {\r\n                background: url('data:image/bmp;base64,Qk1GxwAAAAAAADYAAAAoAAAAggAAAIIAAAABABgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////v7+/v7+/f39/Pz8/Pz8+/v7+/v7+vr6+vr6+vr6+vr6+vr6+vr6+vr6+/v7+/v7/Pz8/Pz8/f39/v7+/v7+/v7+////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AAD////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////+/v79/f38/Pz7+/v5+fn4+Pj29vb19fXz8/Py8vLx8fHw8PDv7+/u7u7u7u7u7u7u7u7u7u7v7+/w8PDx8fHy8vLz8/P19fX29vb4+Pj5+fn7+/v8/Pz9/f3+/v7///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////8AAP////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7+/v39/fz8/Pr6+vj4+PX19fPz8/Dw8O3t7erq6ujo6OXl5ePj4+Hh4d/f393d3dzc3Nvb29vb29ra2tvb29vb29zc3N3d3d/f3+Hh4ePj4+Xl5ejo6Orq6u3t7fDw8PPz8/X19fj4+Pr6+vz8/P39/f7+/v///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wAA/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////v7+/f39+/v7+fn59vb28vLy7+/v6urq5ubm4uLi3t7e2tra19fX1NTU0tLS0NDQz8/Pzc3NzMzMy8vLy8vLysrKysrKysrKy8vLy8vLzMzMzs7Oz8/P0dHR09PT1dXV2NjY29vb3t7e4uLi5+fn6+vr7+/v8/Pz9vb2+fn5+/v7/f39/v7+////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AAD////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////+/v79/f38/Pz5+fn19fXx8fHs7Ozn5+fi4uLd3d3Y2NjU1NTQ0NDKysrAv7+3trWvq6ukoJ+dl5eVj42Oh4aKgYCFfHuDeXiCeXeDeXiFfHuJgH+OhoWTjYyblZWinp2sqKi1s7K9vLzGxcXLy8vNzc3R0dHU1NTY2Njd3d3i4uLo6Ojt7e3y8vL29vb5+fn8/Pz9/f3+/v7///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////8AAP////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7+/v39/fr6+vf39/Ly8u3t7efn5+Hh4dra2tXV1c/Pz8PCwbSysaOfn5OMi4N6eX93doJ5eYd/fo6Fg5KMiZaRjpuVkqKcmaWfnaehnaagnaSenaCcmZ6WlJaRjpKMio6GhIZ/fIJ6eH94dn51dIR8epKLi6Cbm66sq728vMjIyM3NzdHR0dbW1tvb2+Hh4efn5+3t7fPz8/f39/r6+v39/f7+/v///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wAA/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////v7+/Pz8+vr69fX18PDw6enp4uLi29vb1dXVysnJube3pJ+fjoeGgHh2hn58kImFnZaUr6qpu7e0w8G/zMnH0tDP2dfV3tva4eHf5ePi5eXk5+bk5+bl5+Xk5eTj5OLh397d2tjX1NHPzMnIw8C/uba0rqqpn5uYkIqIhX18fnd1fnZ2i4SDnpqZsa+vwsHBy8vL0NDQ1tbW3Nzc4+Pj6urq8PDw9vb2+vr6/Pz8/v7+////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AAD////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////+/v78/Pz5+fn19fXv7+/n5+ff39/X19fNzc24trafm5qIfn6EfXyTi4mooZ67t7XJx8PW0tHg39zm5eXj4uHh3dza2NbY08/RyMfLw8DGvrnDura9say6rqm6rqi+s67Du7fIv7rQx8TW0Mvb19Tg2trh4ODn5+bm4+Pg4N/V09LIxMK5trOppKKSjYuEfXt+dXSFfHuZlZSxrq7DwsLMzMzS0tLY2Njg4ODo6Ojv7+/19fX6+vr9/f3+/v7///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////8AAP////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7+/v39/fr6+vX19e7u7ubm5t7e3tbW1sPCwaejo4yDg4V+fZmSj7KuqsfCwdjU0uLh4OTi4dvZ19HLycS8t7WooKibk6SUi56NgpyMgp+PgqKRhqWUiaiYjaubkaudkquckaqakaqZkKeXjaOSh6GPhKCPg6ORhqeVjKyelbirpsjBvNjS0N/c2+Th4eDf3tXT0cLBv7CurJuVk4V/fH12dImBgKGenbm3t8rKytDQ0NfX19/f3+fn5+/v7/X19fr6+v39/f7+/v///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wAA/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////f39+/v79vb28PDw5+fn3t7e09PTvLq5nJeWg3p4k4uJsKupycTB2tjX5ePj3dzb0MrJvrSvqZ2Vn5GEnIx9oZGFq5uRs6eew7qy1s7H29TN4NvW5+Lc7Obj7Onj7+zo8e3o8e3p8e3p7+vp7ero6ubk5+Hf4dnW2dLPysK+ua6prqCXpJKHoI6EpZSJsKOcxLq22NHR4N3d4ODd19TSw8HArqqplZCNgnt6fXV0l5GRsa+vxsbGz8/P1tbW39/f6Ojo8PDw9/f3+/v7/f39////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AAD////////////////////////////////////////////////////////////////////////////////////////////////////////////////+/v78/Pz4+Pjy8vLp6eng4ODU1NS6uLeZkZGFfXygmZbBvbrW09Hj4uHf3NvNx8SyqKKikoiaiXufkYSun5XGvLPZ0srk4Njs6OLt6uPt6uTt6+Xv7Ofw7efv7ujx7+ry8Orz8ezz8u318+718+/39PD39fD49vH49vP49vL49vP39vT49vT29PLt6+nh29nOxsK0qKGlk4qbjH6nlo2+savTzs3e3Nzc2tnR0M27t7ainpuGfn5/dnaSjYyurKzGxcXPz8/X19fh4eHq6ury8vL4+Pj8/Pz+/v7///////////////////////////////////////////////////////////////////////////////////////////////////////////////////8AAP////////////////////////////////////////////////////////////////////////////////////////////////////////////39/fr6+vX19e3t7ePj49jY2L+8vJmTkoiAf6ign8jDwd3a2eLh4dHOy7euqJ+RhZmJeqKShrWqodPOxuTf1+jl3url3urn3urp4Ovq4uzq4+zr5O3s5e/u5/Du6PDv6fHv6vLw6vPx7PPy7fXz7vX07/f18Pf18Pj28fn28/n38/n39fr49fr59vr59vr49vv49/r39fj29PDt6+Hc2sO3sqiXkJ6MfKmZjsG1sNnW093b2tHQz8C/vKikoomEgn93dpONjbGvr8nJydHR0dra2uTk5O7u7vX19fv7+/39/f///////////////////////////////////////////////////////////////////////////////////////////////////////////////wAA/////////////////////////////////////////////////////////////////////////////////////////////////////v7+/Pz8+Pj48fHx6Ojo3d3dyMbGop2ch399qaKfysjE4N7a4d/cyMLAqZ2Vm4p7no2Bsqed0c3G49/X6OXe5+Pc5uPb6Obd6efe6uje6ung6+ri7Orj7Ovk7ezl7+7m8O7n8O/p8e/q8vDq8/Hs8/Lt9fPu9fTv9/Xw9/Xw+Pbx+fbz+ffz+ff1+vj1+vn2+vn2+/n2+/n3+/r3/Pr4/Pr4+/n3+Pf18/Hv4dvYv7SupJKJno2AsaWdz8jF2tnZ0dDOwsG+qKWhiIKBf3V1mZSTuLa2zMzM1NTU3t7e6enp8vLy+fn5/Pz8/v7+////////////////////////////////////////////////////////////////////////////////////////////////////////AAD////////////////////////////////////////////////////////////////////////////////////////////////+/v77+/v29vbu7u7j4+PT09KwrKuLgoGdlpTIxcLg3tre3NvEvLmklY2VhnmikYbAt67c19Hk4dnl4tnl4tjl49nm5Nvm5Nvo5t3p597p6N7q6ODr6uLs6uPs6+Tt7OXv7ubw7ufw7+nx7+rx8Orz8ezz8u318+719O/39fD39fD49vH59vP59/P59/X6+PX6+fb6+fb7+ff7+ff7+vj8+vj8+vj8+/n8+/n8+/n6+vj59/bu6+rOxcKrnZKei32voJXMxsPa2NjOzcvAvryjnpyFgX+EfXykoJ/CwcHPz8/Z2dnk5OTu7u729vb7+/v+/v7///////////////////////////////////////////////////////////////////////////////////////////////////8AAP////////////////////////////////////////////////////////////////////////////////////////////39/fr6+vT09Orq6t7e3sPBwZmSkpKLicC6t9za2OHf3MfAvKWVjZaHeaeYjsnDvODb1eTg1+Pg1+Pg1uPh1+Ti1+Xj2eXj2ubk2+jm3enn3eno3uro4Ozq4uzp4uzr5O3s5fLy697b0dHNwO7s5vLw6vLx7PPy7XZrRnZrRvf18Pf18Pr49OHe1tTQw/b08fr49fr59vv59vr49vv69/v6+Pz6+Pz6+Pz7+fz7+fz7+vz7+vz7+vv6+vr59/Tx8NvV0rKknZ6Mf6+gldLLyNjY1svIx7m2tJiTkYN7eZKLirOxsMzMzNXV1eDg4Ovr6/T09Pr6+v39/f///////////////////////////////////////////////////////////////////////////////////////////////wAA/////////////////////////////////////////////////////////////////////////////////////////f39+fn58fHx5+fn19fWs66ui4SCraem1dLP5uThzsjEqJuUlYV4ppWLycO84NzW4t7W4t7V4t3U4uDV4+DW4+HW5OHY5ePY5ePZ5uTb6Obc6efd6eje7evl397U2dbK7Orj7ezl9fXwz8u+rqiS5uPb8vDr8vHs8vHsdmtGdmtG9/Xw9/Xw+ff1wb2st7Ke9vTy+vj1+/r37uvm2tbM+vj2+/r4/Pr4/Pr5/Pr5/Pv5/Pv6/Pv6/Pv6/Pv6/fz6/fz7+/r59/Ty3djVr6GZnot9tKaf2NPR1NPSxMPBraqojIaEgXp5pKCfxcTE0dHR3Nzc6Ojo8vLy+fn5/f39/v7+////////////////////////////////////////////////////////////////////////////////////////AAD////////////////////////////////////////////////////////////////////////////////+/v79/f34+Pjv7+/k5OTNzMyim5uUjInGwL/i4N7a2dW3q6eZiHydjH/BuLHd2tPh3tXg3dTg3NPh3dPi3tTi3tXj4Nbj4dbk4djl49jm5Nvj4Nfl5Nnp593p59708+/FwLCuqJLq6ODt6+X29fHb2M+0rpri4Nfy8Ovy8ezz8u12a0Z2a0b39fD39vH29fK/uqjGwbL39vT6+PX8/PrKxreqpI308u/7+vj8+vj6+fj08/D5+Pb8+/r8+/r8+/r8/Pr9/Pv9/Pv9/Pv9/Pv7+vj08vDSy8anlo2gjoPDubbZ1dXIx8W9ubeblpSDenqYk5K6ubnOzs7Z2dnl5eXw8PD4+Pj9/f3+/v7///////////////////////////////////////////////////////////////////////////////////8AAP////////////////////////////////////////////////////////////////////////////7+/vz8/Pf39+7u7uLi4sPBwJONjKafndXSz+fk4cfBv5+RipaFeLOpoNrXz+Hc1ODc1N/c0+Dd0+Dd1ODd0+He1OLe1eLg1uPh1uPi2OXi2PDv6s7Lvb+6qOHg1enn3vTz79jVyreynujl3u3r5PHx7PX08evp4+7s5vLv6/Lx6/Py7XZrRnZrRvb08Pf18Pn49e3r5/Dw6/n39fr49f38+8vHucC7qfn49fv6+Pz7+uDe1ry3pOfl3vz7+vz7+vz7+v38+v38+/38+/38+/38+/38+/38/Pr5+PDv7cS6tZ2Mf6yelNLLydHQzcC+vKmnpImEgoyFhbCurczMzNfX1+Pj4+/v7/j4+Pz8/P7+/v///////////////////////////////////////////////////////////////////////////////wAA/////////////////////////////////////////////////////////////////////////v7+/Pz89/f37e3t397euLW1j4iGurWy393a3tvZt62nlYZ4oZGFzcbB39vT4NvT39vS3tvS39zS39zT4d3T4N3U4d7T4t7V6OXd2dbK5OLX5OLY8vHs29jOqaOL19TI6efe7e3m9/b08O7q7Ori7Ovk7u3m8fDp8vHs8fDq8vDq8vDr8/HsdmtGdmtG9vTw9/Xw+Pfy+vj0+fj0+ff1+vf1/Pv59vbz9fXy+/n4+/r4/fz8u7Wjr6mU8O7q/Pv6/Pv69fTx8/Hu/fz7/fz7/fz7/fz7/fz8/fz8/f38/f38+fj34tvYrZ+Un42Awrq21dPSwsC+trOxko6LhH18qKSkycnJ1dXV4uLi7u7u9/f3/Pz8/v7+////////////////////////////////////////////////////////////////////////////AAD////////////////////////////////////////////////////////////////////+/v78/Pz29vbs7Ozc29uxrayRiojIxMLk4d/SzsynmZGUhHexpp3a19Dg29Te2tLd2tHe29He29Hf3NLf3NPh3dPg3dTh3dXq5t/a182zrJfd2c3k4tjq6OD29fPU0cXj4dfp593p59/r6uPs6uPs6uPs6+Tu7Obv7ebw7ujw7+nx8Ory8Ovz8ex2a0Z2a0b29O/39fD39vH49vH59/P59/X6+PX6+Pb6+fj7+ff7+fj7+vj+/f3W08jf3dX8+/r8+/r8+/rU0cW8t6Tx8Oz9/Pv9/Pv9/Pv9/Pz9/fz9/fz9/fz9/fz9/Pvw7uzGu7adinu2p5/V0tHGxcK5t7WblpWEfXyhnJzFxcXU1NTh4eHu7u739/f8/Pz+/v7///////////////////////////////////////////////////////////////////////8AAP////////////////////////////////////////////////////////////////7+/vz8/Pb29uzs7Nva2qunppiRkNLOy+Xj4MjBvZyNgpqKfMS9tt3a09/b093Y0NzZ0N3a0d7b0d7b0d/c0t3a0Id9XN/c0+Hd1e7s5uLg2LCqlNPPwuTi2OXi2O7s5vLx7Ono4Onn3enn3+rp4evp4uzq4+zq5O3s5e7t5vDu6PDu6fHw6fLw6/Lx7HZrRnZrRvb07/f18Pf28fj28fn38/n38/n49fr49vr49/v59/v59/v6+Pz7+v39/P37+vz7+fz7+vn597y3pb+6qPb18v38+/38+/38/Pr5+P39/P39/P39/P79/P79/f79/fr499rS0KKRhqmYjtLMy8nIxbi3s6GenIV/f52ZmMLCwtTU1OHh4e7u7vf39/z8/P7+/v///////////////////////////////////////////////////////////////////wAA/////////////////////////////////////////////////////////////v7+/f399/f37e3t2dnYqaSjoJeW2dTS5eLevLSulYZ6oZGG0c3G3trT3trS29jP29jP3NnQ3drR3trR3tvR39zScmdBcGU+ysW24dzV5uTc9fPw6eji5OLZ5OLY5OLY5ePa5uXc6Obc6Obd6eff6ejg6+nh6+rj7Ork7ezk7+3m7+7o8O7p8O/p8vDr8vHrdmtGdmtG9vTv9vXw9/Xw9/by+ffz+ffz+fj1+vj2+vn2+vn3+/n3+/r4+/r4+/r5/Pr5/Pv5/Pv6/Pz66unj8O/r/Pv6/fz7/fz7+ff3dGlDta+a/f38/v38/v38/v39/v39/v39+/v66eblr6CYoZCEy8TCzMvIt7WzqaWjh4OBnJaWwcDA1NTU4eHh7u7u+Pj4/f39/v7+////////////////////////////////////////////////////////////////AAD////////////////////////////////////////////////////////////9/f34+Pju7u7a2tmppKOmn53a2NTh396zqaWTg3SpmpHY1M7e3NTd2dHb2M/b2M/b2M/c2c/d2tDd2tHe29He29KvqZNwZT50aUPe29Dh3dTk4tnn5d3j4tnk4dfk4tjl49nl5Nvn5dzo5t3p597q59/q6eHr6ePs6uPs7OXu7ebv7efw7ujx7+rx8Ory8Ovz8ezx8Or18+/29e/39fD49vH49/L59/P59/T6+Pb6+fb6+ff7+ff7+vj7+vj8+vj8+/n8+/r8+/r9/Pv9/fz9/Pv9/Pv9/Pv9/PuvqZNwZT50akT9/fz+/fz+/f3+/f3+/f3+/f3+/f39/Pzx7+29sqyei3zDu7fOy8q4tLGqp6WKhISblZTBwMDU1NTi4uLv7+/4+Pj9/f3///////////////////////////////////////////////////////////////8AAP////////////////////////////////////////////////////////39/fn5+e/v793c3KqlpKafndva197b2bCknpODdbGmndvX0t/b09zYz9vYztvYz9vYz9vYz9zZz97b09zYz97b0d7b0tzZz3VqRHBlPq+pkuHd1OHe1OLf1ePg1uPh1+Ti2OTi2ebk2+fl3Ojm3ejn3ero3+ro4evp4uvq4+3q5e3t5u/t5vDu6PHv6vHv6vLw6/Lx7PTz7vXz7/b17/f18Pj28fj28vn38/n39Pr49vr59vr59vr59/v6+Pv6+Pz6+Pz7+fz7+vz7+v38+v38+/38+/38+/38+/f183BlPnBlPvX18v39/P38+/38/P79/f79/f79/f79/f7+/f7+/fX088i/uZ6LfMG2ss7Myreyr6ypp4qEhJyWlsPDwtXV1eTk5PDw8Pn5+f39/f///////////////////////////////////////////////////////////wAA/////////////////////////////////////////////////////v7++vr68fHx4N/fr6qpopuY29nW3tzbq5+Zk4N0t6yk3NjS3tvT29fO29jO29jO29jO29jP29jP5+Tez8u+wbyr2tbO3drR3dvRzsq8cGU+cWY/3dnO4d7U4t/V4+DV4+HX5OLY5OLZ5eTb5uXc6Obc6Obd6eje6ujg6+ni6+rj7Ork7ezl7+3m7+7o8e/p8e/q8vDr8vHs8/Lu9PPu9vPv9vXw+Pbw+Pby+Pfy+ff0+vj1+vj2+vn2+vn3+/r4+/r4/Pr4/Pv5/Pv6/Pz6/fz6/fz7/fz7/fz7/Pv6jYRlcGU+m5N3/f38/v386+nkysW28vDt/v39/v39/v79/v79/v79/v79+ff3zcbBnot9vrSvysnItrGvqqeliIOCnZmYxsbG19fX5eXl8vLy+vr6/v7+////////////////////////////////////////////////////////AAD////////////////////////////////////////////////+/v77+/vz8/Pl5OS2srGclZLa19Tf3duroJmUg3a5rqbd2dPe2tLZ187a187b187b2M7b2M7b2M7b2M/x8OvJxba5tKDT0MTd2tDd2tHe29CGfVxwZT6Timzh3dTh3tXi39bj4dfj4dfk4tnk4tvm5Nvn5tzo5t3o593q6ODq6eDr6ePs6+Pt7OXu7ebv7efw7unx7+ry8Ovy8Ovy8u318+718+/29fD29vH49vH49/L59/L5+PT6+Pb6+fb6+ff7+vf7+vj8+/j8+/n8+/r9/Pr9/Pr9/Pv9/Pv9/Pvr6ONwZT5xZj/5+Pb9/fz8+vnU0MWvqZPk4tv+/f3+/f3+/v3+/v3+/v3+/v7+/v76+fjQycWfjX7BtrHKyMe0sq6npKGGgYCinZ3KysrZ2dno6Oj09PT7+/v+/v7///////////////////////////////////////////////////8AAP////////////////////////////////////////////////z8/Pb29unp6b67u5aQjdbTz+Pf3bClnpODdriup93a0+Dd1NrXztrWzdrXztrXztvXztvYztvYztvYzunn4fHv7O7s5+Hf1t3a0N3a0N3a0dnWy3BlPnBlPtDMvuHd1OLf1eLg1uPh1+Ti2OXi2eXk2+fl2+jm3Onm3uno3+ro4Ovp4uvq4+3r5O3s5e/t5+/t6PHv6fHv6vLw6/Py7fTy7vXz7/b07/f18Pf28fj28vj38vn48/r49Pr59vr59vv69/v6+Pv6+Pz7+fz7+v37+v38+v38+v38+/v6+HdsR3BlPr65p/39/P79/Pv7+fT08enn4fr5+P79/f7+/f7+/f7+/f7+/f7+/v7+/v7+/vr6+dHJxp+LfsC2ssfEwrSvrqCcnIV+fqmlpc/Pz9zc3Ovr6/b29v39/f///////////////////////////////////////////////////wAA/////////////////////////////////////////////f39+Pj47e3ty8jIlYuL0MrH5+Pgt66ok4N0s6qh3NjS4d3W3NvS2tjR2dbN2tfO2tfO4uDY08/D0c7B29jN3NnR4N3V39zT3drQ3NrQ3drQ3drR3tvRmJB0fXNQv7qn4d3U4t7U4t/W4+HX4+HX5ePZ5ePa5uXb5+Xc6efd6efe6ujg6uni7Ori7Ork7ezl7u3m8O7o8O7p8e/q8e/q8/Hr8/Lu9fPu9fTv9/Xw9/bx+Pbx+Pfy+fjz+fj0+vj1+vn2+/r3+/r4+/r4/Pv5/Pv6/Pv6/fz6/fz6/fz7z8q9cGU+dWpF+vr4/f38/v38/v38/v39/v39/v39/v39+/r55OLb9/f0/v79/v7+/v7+/v7+/v7++vn4zcO+not8xLy5wsC/s7CumJWShX19sa+u0tLS4ODg7+/v+fn5/f39////////////////////////////////////////////////AAD////////////////////////////////////////+/v76+vrx8fHX1tWak5PBvbno4+DAt7OUhHeuo5nc2NHg3NXd3NPc3NPb2tHZ1s3a187c2dHu7Oi2sJ27tqTa2M7b2M/b2M/b2M/c2c/c2dDd2tDd2tDd29Hd2tDd2tDg3NPh3dTh3tTi39bj4Nbj4dfk4tjl49rm5dvn5dvo5t3p597q6N7q6OHr6uPs6uPt6+Tu7OXw7ufw7ujx7+nx7+ry8evz8u308u718+/29O/39vH39vH49vL59/L5+PT5+PX6+fb7+vf7+vf7+vj8+/j8+/n8+/r9+/r9/Pr9/Pv7+vizrZjf3dT9/fz+/fz+/fz+/fz+/f3+/f3+/f3+/f3l49yrpI3W08f+/v3+/v3+/v7+/v7+/v7+/v749/fEubSgjYHIwb6+u7m0sa+RjIuNhoa8u7rV1dXk5OTy8vL7+/v+/v7///////////////////////////////////////////8AAP////////////////////////////////////////z8/PT09OTj46ijo66op+Th3cvFwpaIfKeYkdrX0uHc1tzc093c09zc093c0tnY0NvXz9za0fLw7eTi2+He1tzZz9vYz9vYz9vYz9zZz9zZ0Nza0N3a0N3a0d7b0t7c0uDc0+Dd0+Hd1eLf1eLg1uPh1+Th1+Xj2uXk2ufl2+jl3Onn3enn3uro4Oro4uzq4+3r5O7s5e/t5fDu6PDu6fHv6vHv6vPx7PPy7vXz7vX08Pf18Pf28fj28vn38/n48/n49fr59vr59/v69/v6+Pv7+Pz7+fz7+v37+v37+v38+v38+/38+/39/P39/P79/P79/P79/P79/f79/f79/f7+/fT08dTQxe3s5v7+/f7+/f7+/v7+/v7+/v7+/v7+/vXz8risoqSSicjEw7q3tK+sqomCgZiTksfGxtnZ2enp6fX19fz8/P///////////////////////////////////////////wAA/////////////////////////////////////f39+Pj47Ozsu7i3nZWS3NrW2dXRnpCHn5GF1M/L4NzV3tvU3dzT3dzT3dzT3NvT3dzQ2tjN29jP393V5+Xf3tzU2tfO29jO29jP29jP29jP3NnP3NnQ3NrQ3drQ3tvR3tvS39zS4NzT4d3T4d7V4uDV4uDW5OHX5OLY5ePa5uTa6Obc6Obc6efd6ujf6+nh6+ni7Orj7evk7u3l7+3n8O7o8e/p8vDq8vDr8/Hs9PLu9fPv9vTw9/Xx9/bx+Pfy+ffz+fj1+fj1+vn2+vr3+/r3+/r4/Pv5/Pv5/Pv6/fv6/fz6/fz7/fz7/f37/f38/f38/v38/v38/v38/v39/v39/v39/v7+/v7+/v79/v79/v79/v79/v79/v7+/v7+/v7+/v7+7+vqrZySrp6UyMTCtrSwpqOhhH18paGh0NDQ39/f7u7u+fn5/f39////////////////////////////////////////AAD////////////////////////////////+/v77+/vx8fHRzs6VjYzRzMji4N2onpeYi33JxsDf29Te3NTb29Lc3NPd3NPd3NTi4drX1MnX1Mnb2M7b2M/a187a187a187b2M7b2M7b2M/b2M/c2c/c2c/c2dDd2tDd29He29He29Lg3NLh3dTh3tTi3tXi4Nbj4Nbk4tjl4tnm5Nrn5dvo5tzp593p597q6ODr6eLs6uPs6+Pu7eTv7efw7ujw7ujx7+ry8Ovz8ez08u318+/29O/29fD39vH49/L49/P5+PP5+PX6+fX6+ff7+vf7+vj8+/n8+/n8+/n8+/r9/Pr9/Pr9/Pv9/Pv9/fz9/fz+/fz+/fz+/fz+/f3+/f3+/f3+/v3+/v3+/v3+/v3m5NzTz8P4+Pb+/v3+/v7+/v7+/v79/Pzk3tugjoC2qqfCwL62sa+WlJGDe3u1tLPV1dXl5eXz8/P7+/v+/v7///////////////////////////////////8AAP////////////////////////////////39/fb29uPi4qOcnLu2sefl4b+0rpWFebyzrt/b1eHd1Nzb0dva0dzb0tzb0uLi2uvp5LCqlMO/r9rXz9vYz9rXztrXztrXztvYztvYztvYz9vYz9zZz9zZz9zZ0Nza0N3a0d7b0d7b0t/c0uDd0+Hd1OHe1eLg1eLh1+Th1+Ti2eXk2ubk2ujm3Ojm3Onn3ern3+vp4evp4uzq4+3s5O7t5u/t5/Du6PHv6fLw6vLw6/Px7fTz7vXz7/b18Pb18fj28fj38/j38/n49fr59vr59vr69/v69/v7+Pz7+fz7+fz7+f37+v38+v38+/38+/39/P39/P39/P79/P79/P79/P79/f79/f7+/f7+/f7+/f7+/c3Ju7Grluzq5f7+/f7+/f7+/f7+/v7+/vv7+9LLx56Lfb+4tLu5t7Sxr4qFhJOMi8bFxdvb2+vr6/f39/39/f///////////////////////////////////wAA/////////////////////////////v7++vr67+/vvrq6n5eV39rZzsjFmoyBrJ6W29nU4t3W4N3T3dzS29rQ3NvR3dzR39/W9vbz29jO4N3V2tjP29jP2tfO2tfO2tfO29jO29jO29jO29jP29nP3NnP3NnP3NnQ3drQ3dvR3tvR39vS4N3S4d3U4d7U4t/V4+DV4+HX5OLY5ePZ5uXa5uXb6Obc6ebd6eje6+jh6+ni7Orj7Ovk7uzk7+3n8O7n8O/p8u/q8vDr8/Hs9PPu9fPv9vTv9vXw9/bw+Pfy+Pfz+fj0+fj2+vn2+vn3+/r3+/r4/Pv5/Pv5/Pv5/fv6/fz6/fz6/fz7/f37/f38/f38/v38/v38/v38/v39/v39/v79/v79/v79/v7+9fXy7uzo/v79/v79/v79/v79/v79/v79/v7++Pf3vbCqopGFxcDAtrSwp6Signx7pqOj0tLS4eHh8PDw+vr6/v7+////////////////////////////////AAD////////////////////////////8/Pz09PTY19eXjo3OyMXh39ypnJSfkYXT0Mzg29Tg3NPg3NPe3dPc29Hd29Hc29Hc29Lk49zq6uPh4dba2c/b18/a18/a187a187a187a2M7b2M7b2M7b2M/b2M/c2c/c2c/d2tDd2tDd29He29Hf3NLg3NPh3dTh3tTi39bj4Nbj4dfk4tjl49rm5Nrn5dvo5tzp5t3q6N/q6OHr6eLs6uPt7OTu7OXv7efw7ujx7+nx7+ry8Orz8uz08u718+729e/39vH39vH49/L49/P5+PT5+Pb6+fb6+ff7+vj7+vj8+vn8+/n8+/n9+/n9/Pr9/Pr9/Pv9/fv9/fz9/fz+/fz+/fz+/fz+/fz+/f3+/f3+/v3+/v3+/v3+/v3+/v3+/v3+/v3+/v3+/v3+/v3+/v3+/v3r6OeolYyuop7Avry2tLGVko6Gf367urrY2Njo6Oj29vb9/f3///////////////////////////////8AAP////////////////////////7+/vn5+ezs7LCrqq6ppuXh3sC3speJfMC4s+Dc1eLc1eHc0+He1ODd1d3c0+Dg1drYzNzb0d3c0t3c09zc0tzaz9rYz9vYz9rXztrXztrXztrXztvYztvYztvYz9vYz9vZz9zZz9za0N3a0N3a0d3b0d7c0d/c0+Dd0+Hd1OLe1eLf1uPh1uTh2OTj2ebk2ufl2+jl2+jn3ern3uro4Ovo4evq4+3r4+3s5O/t5u/u6PHu6PHv6fLw6vPw7PPy7fXz7vX07/b17/f28ff28fj38vn48/n49Pr59vr59vv69/v6+Pv6+Pz6+fz7+f37+f37+v38+v38+/39+/39+/39/P79/P79/P79/P79/P79/f79/f79/f7+/f7+/f7+/f7+/fX08tvZz/Hw7P7+/f7+/f7+/f7+/f39/NbOy56NgMC4trm3ta6rqYR/fZyXls/Pz9/f3+/v7/r6+v7+/v///////////////////////////wAA/////////////////////////Pz89PT00tDPlo6N2dTR19LPn5CFq56V29jU4NzU39vT4dzU4t3U4t7V6ebi2dfOsayY09DF3dzT3dzT3dvS29rR2tjO29jP2tfO2tfO2tfO2tfO2tfO29jO29jO29jP29jP3NnP3NnQ3NrQ3drQ3drR3tvS3tzS4NzT4N3U4t3V4t/V4+DW4+HX5OHZ5eTa5+Ta5+Xb6ebc6efd6uff6ujh7Onh7Orj7ezk7uzl8O3n8O7o8e/p8e/p8vDr8/Hs9PLt9fPu9vTv9/Xw9/bx+Pby+Pfy+fj0+fj1+vn2+/r3+/r3+/r4/Pr4/Pv5/Pv5/fv5/fz6/fz7/fz7/f37/f37/f38/v38/v38/v38/v38/v38/v39/v39/v79/v79/v7+4d7WrqeR09DD/v79/v79/v79/v79/v79+fb1uaqipJOLwsC/t7WynZiVf3h3tbSz19fX6Ojo9fX1/Pz8////////////////////////////AAD////////////////////+/v75+fnq6uqooaG7tbLn4+C1qaObjYLOyMXh3tXg29Pe29Lg29Pi29Ti3dXt6+fr6uTDvq7W1Mjd3NPd3NPd3NPd3N[...string is too long...]";
            this.clockBrowser.DocumentText = documentText;
        }

        // Token: 0x06000048 RID: 72 RVA: 0x00005774 File Offset: 0x00003974
        private void FetchAndPopulateTimeZones(ComboBox timeZoneCombo)
        {
            try
            {
                ReadOnlyCollection<TimeZoneInfo> systemTimeZones = TimeZoneInfo.GetSystemTimeZones();
                string id = TimeZoneInfo.Local.Id;
                timeZoneCombo.Items.Clear();
                foreach (TimeZoneInfo timeZoneInfo in systemTimeZones)
                {
                    timeZoneCombo.Items.Add(timeZoneInfo.DisplayName);
                    this.DSTCheckbox.Enabled = timeZoneInfo.SupportsDaylightSavingTime;
                    if (timeZoneInfo.Id == id)
                    {
                        timeZoneCombo.SelectedItem = timeZoneInfo.DisplayName;
                        this.DSTCheckbox.Checked = timeZoneInfo.SupportsDaylightSavingTime;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while fetching time zones: " + ex.Message);
            }
        }

        // Token: 0x06000049 RID: 73 RVA: 0x00005844 File Offset: 0x00003A44
        private void TimeZoneCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                string selectedTimeZoneDisplayName = comboBox.SelectedItem.ToString();
                TimeZoneInfo timeZoneInfo = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault((TimeZoneInfo tz) => tz.DisplayName == selectedTimeZoneDisplayName);
                if (timeZoneInfo != null)
                {
                    this.DSTCheckbox.Enabled = timeZoneInfo.SupportsDaylightSavingTime;
                    if (timeZoneInfo.SupportsDaylightSavingTime)
                    {
                        this.DSTCheckbox.Checked = true;
                    }
                    else
                    {
                        this.DSTCheckbox.Checked = false;
                    }
                    this.SetTimeZone(timeZoneInfo.Id);
                    return;
                }
                Console.WriteLine("Time zone not found: " + selectedTimeZoneDisplayName);
            }
        }

        // Token: 0x0600004A RID: 74 RVA: 0x000058F0 File Offset: 0x00003AF0
        private void SetTimeZone(string timeZoneId)
        {
            if (!this.DSTCheckbox.Checked)
            {
                timeZoneId += "_dstoff";
            }
            try
            {
                using (Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = "tzutil.exe",
                    Arguments = "/s \"" + timeZoneId + "\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }))
                {
                    process.WaitForExit();
                    process.StandardOutput.ReadToEnd();
                    string text = process.StandardError.ReadToEnd();
                    if (!string.IsNullOrEmpty(text))
                    {
                        throw new Exception(text);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        // Token: 0x0600004B RID: 75 RVA: 0x000059BC File Offset: 0x00003BBC
        private void nextButton_Click(object sender, EventArgs e)
        {
            License form = new License(this._mainForm);
            this._mainForm.LoadFormIntoPanel(form);
        }

        // Token: 0x0600004C RID: 76 RVA: 0x000059E4 File Offset: 0x00003BE4
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime start = e.Start;
            TimeAndDate.ChangeDate.SYSTEMTIME systemtime = new TimeAndDate.ChangeDate.SYSTEMTIME
            {
                wYear = (ushort)start.Year,
                wMonth = (ushort)start.Month,
                wDay = (ushort)start.Day,
                wHour = (ushort)DateTime.Now.Hour,
                wMinute = (ushort)DateTime.Now.Minute,
                wSecond = (ushort)DateTime.Now.Second,
                wMilliseconds = (ushort)DateTime.Now.Millisecond
            };
            TimeAndDate.ChangeDate.SetSystemTime(ref systemtime);
        }

        // Token: 0x04000049 RID: 73
        private Main _mainForm;

        // Token: 0x0200000F RID: 15
        public class ChangeDate
        {
            // Token: 0x0600006C RID: 108
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool SetSystemTime(ref TimeAndDate.ChangeDate.SYSTEMTIME st);

            // Token: 0x02000011 RID: 17
            public struct SYSTEMTIME
            {
                // Token: 0x0400005F RID: 95
                public ushort wYear;

                // Token: 0x04000060 RID: 96
                public ushort wMonth;

                // Token: 0x04000061 RID: 97
                public ushort wDayOfWeek;

                // Token: 0x04000062 RID: 98
                public ushort wDay;

                // Token: 0x04000063 RID: 99
                public ushort wHour;

                // Token: 0x04000064 RID: 100
                public ushort wMinute;

                // Token: 0x04000065 RID: 101
                public ushort wSecond;

                // Token: 0x04000066 RID: 102
                public ushort wMilliseconds;
            }
        }
    }
}
