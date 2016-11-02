using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace NodeVector
{

    public partial class Form1 : Form
    {
        private Node[] nodes;

        public Form1()
        {
            InitializeComponent();

            nodes = new Node[96];

            //nodes[13] = new NodeVector.Node(10, 10);

            for (int i=0; i<96; i++){

                nodes[i] = new Node();
                nodes[i].label = i;
            }
            //nodes[13].addPull(70.1, 121, 216);
            //nodes[13].addPull(239.45, 130, 178);
            //nodes[13].addPull(22.95, 23, 218);
            //nodes[13].addPull(55.95, 29, 145);
            //nodes[13].addPull(58.75, 30, 182);
            //nodes[13].addPull(101.75, 88, 168);
            //nodes[13].addPull(70, 91, 218);

            //nodes[0].addPull(10, 50, 50);
            //nodes[0].addPull(10, 60, 50);
            //nodes[0].addPull(10, 50, 60);
            //nodes[0].addPull(10, 60, 60);

            //nodes[1].addPull(10, 40, 40);
            //nodes[1].addPull(10, 60, 40);
            //nodes[1].addPull(10, 50, 60);
            //nodes[1].addPull(10, 60, 40);

            //nodes[10].x = 100;

            //nodes[10].addPull(10, 50, 50);
            //nodes[10].addPull(10, 60, 50);
            //nodes[10].addPull(10, 50, 60);
            //nodes[10].addPull(10, 60, 60);


            //nodes[0].addPull(13.15, 354, 219);
            //nodes[1].addPull(20.35, 354, 219);
            //nodes[2].addPull(12.55, 354, 219);
            //nodes[10].addPull(26.85, 23, 218);
            //nodes[10].addPull(16.6, 2, 183);
            //nodes[12].addPull(27.25, 23, 218);
            //nodes[12].addPull(22.9, 2, 183);
            //nodes[12].addPull(50.85, 30, 182);
            //nodes[13].addPull(70.1, 121, 216);
            //nodes[13].addPull(239.45, 130, 178);
            //nodes[13].addPull(22.95, 23, 218);
            //nodes[13].addPull(55.95, 29, 145);
            //nodes[13].addPull(58.75, 30, 182);
            //nodes[13].addPull(101.75, 88, 168);
            //nodes[13].addPull(70, 91, 218);
            //nodes[14].addPull(68.8, 121, 216);
            //nodes[14].addPull(256.6, 130, 178);
            //nodes[14].addPull(82.05, 88, 168);
            //nodes[14].addPull(55.45, 91, 218);
            //nodes[15].addPull(61.55, 121, 216);
            //nodes[15].addPull(224.25, 130, 178);
            //nodes[15].addPull(96.85, 172, 170);
            //nodes[15].addPull(95.55, 180, 220);
            //nodes[15].addPull(56.4, 215, 219);
            //nodes[16].addPull(99.95, 172, 170);
            //nodes[16].addPull(99.5, 180, 220);
            //nodes[16].addPull(70, 215, 219);
            //nodes[16].addPull(124.7, 236, 187);
            //nodes[17].addPull(84, 180, 220);
            //nodes[17].addPull(74.95, 215, 219);
            //nodes[17].addPull(154.4, 236, 187);
            //nodes[18].addPull(64.95, 215, 219);
            //nodes[18].addPull(157.6, 236, 187);
            //nodes[18].addPull(46.35, 353, 171);
            //nodes[18].addPull(13.95, 354, 219);
            //nodes[19].addPull(123.1, 236, 187);
            //nodes[19].addPull(40.6, 348, 126);
            //nodes[19].addPull(64.75, 353, 171);
            //nodes[19].addPull(20.7, 354, 219);
            //nodes[20].addPull(43.25, 348, 126);
            //nodes[20].addPull(76.35, 353, 171);
            //nodes[20].addPull(31.55, 354, 219);
            //nodes[21].addPull(26.9, 0, 124);
            //nodes[21].addPull(54.25, 121, 216);
            //nodes[21].addPull(29.5, 23, 218);
            //nodes[21].addPull(69.3, 29, 145);
            //nodes[21].addPull(24.3, 2, 183);
            //nodes[21].addPull(71.7, 30, 182);
            //nodes[21].addPull(97.9, 88, 168);
            //nodes[21].addPull(61, 91, 218);
            //nodes[22].addPull(29.25, 0, 124);
            //nodes[22].addPull(35.35, 23, 218);
            //nodes[22].addPull(68.7, 29, 145);
            //nodes[22].addPull(29.15, 2, 183);
            //nodes[22].addPull(74.3, 30, 182);
            //nodes[23].addPull(31.35, 0, 124);
            //nodes[23].addPull(25.05, 23, 218);
            //nodes[23].addPull(63.3, 29, 145);
            //nodes[23].addPull(25, 2, 183);
            //nodes[23].addPull(55.55, 30, 182);
            //nodes[24].addPull(42.35, 0, 124);
            //nodes[24].addPull(37.7, 0, 81);
            //nodes[24].addPull(35, 23, 218);
            //nodes[24].addPull(93.45, 29, 145);
            //nodes[24].addPull(30.9, 2, 183);
            //nodes[24].addPull(85.5, 30, 182);
            //nodes[24].addPull(61.2, 31, 115);
            //nodes[24].addPull(18.35, 38, 81);
            //nodes[24].addPull(87.1, 88, 168);
            //nodes[24].addPull(48.9, 91, 218);
            //nodes[25].addPull(37, 0, 124);
            //nodes[25].addPull(33.9, 0, 81);
            //nodes[25].addPull(23.5, 23, 218);
            //nodes[25].addPull(67.15, 29, 145);
            //nodes[25].addPull(21.05, 2, 183);
            //nodes[25].addPull(51.9, 30, 182);
            //nodes[25].addPull(49.7, 31, 115);
            //nodes[26].addPull(48.5, 0, 124);
            //nodes[26].addPull(18.9, 0, 37);
            //nodes[26].addPull(48.9, 0, 81);
            //nodes[26].addPull(31.1, 23, 218);
            //nodes[26].addPull(100.8, 29, 145);
            //nodes[26].addPull(30.55, 2, 183);
            //nodes[26].addPull(77.95, 30, 182);
            //nodes[26].addPull(75.45, 31, 115);
            //nodes[26].addPull(23.4, 38, 81);
            //nodes[26].addPull(43.8, 40, 48);
            //nodes[26].addPull(21.1, 63, 32);
            //nodes[26].addPull(38.3, 76, 82);
            //nodes[26].addPull(82.4, 86, 126);
            //nodes[26].addPull(90.8, 88, 168);
            //nodes[26].addPull(47.5, 91, 218);
            //nodes[27].addPull(40.9, 0, 124);
            //nodes[27].addPull(19.35, 0, 37);
            //nodes[27].addPull(45.5, 0, 81);
            //nodes[27].addPull(21.6, 23, 218);
            //nodes[27].addPull(63.55, 29, 145);
            //nodes[27].addPull(17.95, 2, 183);
            //nodes[27].addPull(54.9, 31, 115);
            //nodes[27].addPull(19.15, 38, 81);
            //nodes[27].addPull(36.4, 40, 48);
            //nodes[28].addPull(46.5, 0, 124);
            //nodes[28].addPull(23.1, 0, 37);
            //nodes[28].addPull(56.6, 0, 81);
            //nodes[28].addPull(24.75, 23, 218);
            //nodes[28].addPull(89.75, 29, 145);
            //nodes[28].addPull(24, 2, 183);
            //nodes[28].addPull(68.45, 30, 182);
            //nodes[28].addPull(74.8, 31, 115);
            //nodes[28].addPull(27.2, 38, 81);
            //nodes[28].addPull(53.95, 40, 48);
            //nodes[28].addPull(25.7, 63, 32);
            //nodes[28].addPull(43.25, 76, 82);
            //nodes[28].addPull(84.25, 86, 126);
            //nodes[28].addPull(84.15, 88, 168);
            //nodes[29].addPull(29.4, 0, 124);
            //nodes[29].addPull(22.55, 0, 37);
            //nodes[29].addPull(43.3, 0, 81);
            //nodes[29].addPull(18.35, 38, 81);
            //nodes[29].addPull(40.95, 40, 48);
            //nodes[29].addPull(19.9, 63, 32);
            nodes[30].addPull(44.65, 0, 124);
            nodes[30].addPull(30.25, 0, 37);
            nodes[30].addPull(57.5, 0, 81);
            nodes[30].addPull(68.35, 29, 145);
            nodes[30].addPull(18.6, 2, 183);
            nodes[30].addPull(66.45, 31, 115);
            nodes[30].addPull(26.65, 38, 81);
            nodes[30].addPull(60.05, 40, 48);
            nodes[30].addPull(31.25, 63, 32);
            nodes[30].addPull(43.75, 76, 82);
            nodes[31].addPull(40.25, 0, 124);
            nodes[31].addPull(16.95, 0, 37);
            nodes[31].addPull(35.25, 0, 81);
            nodes[31].addPull(61.7, 121, 216);
            nodes[31].addPull(225.1, 130, 178);
            nodes[31].addPull(32.65, 23, 218);
            nodes[31].addPull(90, 29, 145);
            nodes[31].addPull(27.3, 2, 183);
            nodes[31].addPull(85.15, 30, 182);
            nodes[31].addPull(63.9, 31, 115);
            nodes[31].addPull(20.8, 38, 81);
            nodes[31].addPull(35.5, 40, 48);
            nodes[31].addPull(19.9, 63, 32);
            nodes[31].addPull(38.45, 76, 82);
            nodes[31].addPull(92.55, 86, 126);
            nodes[31].addPull(119.65, 88, 168);
            nodes[31].addPull(64.5, 91, 218);
            nodes[32].addPull(34.05, 0, 124);
            nodes[32].addPull(14.95, 0, 37);
            nodes[32].addPull(34.9, 0, 81);
            nodes[32].addPull(82.85, 121, 216);
            nodes[32].addPull(108.8, 127, 106);
            nodes[32].addPull(82.25, 127, 143);
            nodes[32].addPull(296.8, 130, 178);
            nodes[32].addPull(60.35, 130, 72);
            nodes[32].addPull(91.55, 172, 170);
            nodes[32].addPull(27.55, 23, 218);
            nodes[32].addPull(77.8, 29, 145);
            nodes[32].addPull(25.65, 2, 183);
            nodes[32].addPull(75.55, 30, 182);
            nodes[32].addPull(57.3, 31, 115);
            nodes[32].addPull(22, 38, 81);
            nodes[32].addPull(37.8, 76, 82);
            nodes[32].addPull(103.8, 86, 126);
            nodes[32].addPull(131, 88, 168);
            nodes[32].addPull(76.45, 91, 218);
            nodes[33].addPull(80.05, 121, 216);
            nodes[33].addPull(114.15, 127, 106);
            nodes[33].addPull(87.3, 127, 143);
            nodes[33].addPull(325.05, 130, 178);
            nodes[33].addPull(64.15, 130, 72);
            nodes[33].addPull(116.15, 172, 170);
            nodes[33].addPull(164.9, 175, 130);
            nodes[33].addPull(103.4, 180, 220);
            nodes[33].addPull(55.85, 215, 219);
            nodes[33].addPull(58.55, 30, 182);
            nodes[33].addPull(44.95, 31, 115);
            nodes[33].addPull(97.35, 86, 126);
            nodes[33].addPull(114.75, 88, 168);
            nodes[33].addPull(66.95, 91, 218);
            nodes[34].addPull(71.2, 121, 216);
            nodes[34].addPull(105.2, 127, 106);
            nodes[34].addPull(81.2, 127, 143);
            nodes[34].addPull(296.7, 130, 178);
            nodes[34].addPull(41.75, 160, 39);
            nodes[34].addPull(142.7, 170, 79);
            nodes[34].addPull(127.7, 172, 170);
            nodes[34].addPull(181.1, 175, 130);
            nodes[34].addPull(109.1, 180, 220);
            nodes[34].addPull(67.2, 215, 219);
            nodes[34].addPull(77.75, 86, 126);
            nodes[34].addPull(87.2, 88, 168);
            nodes[34].addPull(52.5, 91, 218);
            nodes[35].addPull(56.45, 121, 216);
            nodes[35].addPull(68.95, 127, 143);
            nodes[35].addPull(239.3, 130, 178);
            nodes[35].addPull(141.85, 170, 79);
            nodes[35].addPull(126.8, 172, 170);
            nodes[35].addPull(184.85, 175, 130);
            nodes[35].addPull(113.15, 180, 220);
            nodes[35].addPull(79.65, 215, 219);
            nodes[35].addPull(156.35, 236, 187);
            nodes[36].addPull(106.55, 172, 170);
            nodes[36].addPull(159.95, 175, 130);
            nodes[36].addPull(99.55, 180, 220);
            nodes[36].addPull(82.3, 215, 219);
            nodes[36].addPull(187.8, 236, 187);
            nodes[36].addPull(204.55, 262, 100);
            nodes[37].addPull(84.3, 180, 220);
            nodes[37].addPull(75.85, 215, 219);
            nodes[37].addPull(189.3, 236, 187);
            nodes[37].addPull(227.85, 262, 100);
            nodes[37].addPull(63.55, 295, 65);
            nodes[37].addPull(44.2, 348, 126);
            nodes[37].addPull(60.85, 353, 171);
            nodes[37].addPull(14.05, 354, 219);
            nodes[38].addPull(54.3, 215, 219);
            nodes[38].addPull(155.65, 236, 187);
            nodes[38].addPull(218.65, 262, 100);
            nodes[38].addPull(46.55, 297, 53);
            nodes[38].addPull(81.85, 347, 80);
            nodes[38].addPull(61.65, 348, 126);
            nodes[38].addPull(82.85, 353, 171);
            nodes[38].addPull(24.3, 354, 219);
            nodes[39].addPull(90.95, 347, 80);
            nodes[39].addPull(67.2, 348, 126);
            nodes[39].addPull(96.25, 353, 171);
            nodes[39].addPull(28.05, 354, 219);
            nodes[40].addPull(45.65, 0, 124);
            nodes[40].addPull(20.3, 0, 37);
            nodes[40].addPull(47.55, 0, 81);
            nodes[40].addPull(62.75, 121, 216);
            nodes[40].addPull(102.55, 127, 106);
            nodes[40].addPull(75.6, 127, 143);
            nodes[40].addPull(233.15, 130, 178);
            nodes[40].addPull(63.95, 130, 72);
            nodes[40].addPull(77.55, 131, 39);
            nodes[40].addPull(31.15, 23, 218);
            nodes[40].addPull(100.45, 29, 145);
            nodes[40].addPull(27.3, 2, 183);
            nodes[40].addPull(83.85, 30, 182);
            nodes[40].addPull(77.8, 31, 115);
            nodes[40].addPull(25.25, 38, 81);
            nodes[40].addPull(48.9, 40, 48);
            nodes[40].addPull(26.75, 63, 32);
            nodes[40].addPull(47.35, 76, 82);
            nodes[40].addPull(111.85, 86, 126);
            nodes[40].addPull(120.15, 88, 168);
            nodes[40].addPull(65.7, 91, 218);
            nodes[41].addPull(44.05, 0, 124);
            nodes[41].addPull(25.35, 0, 37);
            nodes[41].addPull(53, 0, 81);
            nodes[41].addPull(56.9, 121, 216);
            nodes[41].addPull(109, 127, 106);
            nodes[41].addPull(68.15, 127, 143);
            nodes[41].addPull(207.4, 130, 178);
            nodes[41].addPull(70.85, 130, 72);
            nodes[41].addPull(85.65, 131, 39);
            nodes[41].addPull(25.8, 23, 218);
            nodes[41].addPull(87.85, 29, 145);
            nodes[41].addPull(26, 2, 183);
            nodes[41].addPull(67.35, 30, 182);
            nodes[41].addPull(80.45, 31, 115);
            nodes[41].addPull(27.7, 38, 81);
            nodes[41].addPull(54.85, 40, 48);
            nodes[41].addPull(30.65, 63, 32);
            nodes[41].addPull(53.6, 76, 82);
            nodes[41].addPull(108.45, 86, 126);
            nodes[41].addPull(104.85, 88, 168);
            nodes[41].addPull(54.1, 91, 218);
            nodes[42].addPull(40.55, 0, 124);
            nodes[42].addPull(24.15, 0, 37);
            nodes[42].addPull(50.4, 0, 81);
            nodes[42].addPull(99.4, 127, 106);
            nodes[42].addPull(64.25, 130, 72);
            nodes[42].addPull(89.5, 131, 39);
            nodes[42].addPull(21, 23, 218);
            nodes[42].addPull(74.2, 29, 145);
            nodes[42].addPull(19.6, 2, 183);
            nodes[42].addPull(58.1, 30, 182);
            nodes[42].addPull(67.5, 31, 115);
            nodes[42].addPull(28.4, 38, 81);
            nodes[42].addPull(62.05, 40, 48);
            nodes[42].addPull(36.25, 63, 32);
            nodes[42].addPull(54.6, 76, 82);
            nodes[42].addPull(95.75, 86, 126);
            nodes[42].addPull(85.65, 88, 168);
            nodes[43].addPull(19.8, 0, 37);
            nodes[43].addPull(29.8, 0, 81);
            nodes[44].addPull(14.75, 0, 37);
            nodes[45].addPull(25.45, 0, 37);
            nodes[45].addPull(43.6, 0, 81);
            nodes[45].addPull(46.5, 31, 115);
            nodes[45].addPull(20.6, 38, 81);
            nodes[45].addPull(56.1, 40, 48);
            nodes[45].addPull(24.9, 63, 32);
            nodes[46].addPull(58.3, 353, 171);
            nodes[46].addPull(17.65, 354, 219);
            nodes[47].addPull(38.85, 0, 124);
            nodes[47].addPull(19.45, 0, 37);
            nodes[47].addPull(39.25, 0, 81);
            nodes[47].addPull(77.35, 121, 216);
            nodes[47].addPull(134.6, 127, 106);
            nodes[47].addPull(93.65, 127, 143);
            nodes[47].addPull(301.45, 130, 178);
            nodes[47].addPull(76.85, 130, 72);
            nodes[47].addPull(95.2, 131, 39);
            nodes[47].addPull(46.1, 160, 39);
            nodes[47].addPull(145.1, 170, 79);
            nodes[47].addPull(94.35, 172, 170);
            nodes[47].addPull(157.75, 175, 130);
            nodes[47].addPull(86.1, 180, 220);
            nodes[47].addPull(27.55, 23, 218);
            nodes[47].addPull(85.95, 29, 145);
            nodes[47].addPull(23.1, 2, 183);
            nodes[47].addPull(76.3, 30, 182);
            nodes[47].addPull(67.8, 31, 115);
            nodes[47].addPull(24.7, 38, 81);
            nodes[47].addPull(42.3, 40, 48);
            nodes[47].addPull(25.1, 63, 32);
            nodes[47].addPull(51.25, 76, 82);
            nodes[47].addPull(124.9, 86, 126);
            nodes[47].addPull(132.9, 88, 168);
            nodes[47].addPull(69.1, 91, 218);
            nodes[48].addPull(30.35, 0, 124);
            nodes[48].addPull(14.95, 0, 37);
            nodes[48].addPull(30.55, 0, 81);
            nodes[48].addPull(79.5, 121, 216);
            nodes[48].addPull(145.35, 127, 106);
            nodes[48].addPull(100.7, 127, 143);
            nodes[48].addPull(329.6, 130, 178);
            nodes[48].addPull(84.15, 130, 72);
            nodes[48].addPull(107.4, 131, 39);
            nodes[48].addPull(54.8, 160, 39);
            nodes[48].addPull(173.35, 170, 79);
            nodes[48].addPull(123.7, 172, 170);
            nodes[48].addPull(199.5, 175, 130);
            nodes[48].addPull(106.85, 180, 220);
            nodes[48].addPull(59.3, 215, 219);
            nodes[48].addPull(23.3, 23, 218);
            nodes[48].addPull(66, 29, 145);
            nodes[48].addPull(20.3, 2, 183);
            nodes[48].addPull(64.6, 30, 182);
            nodes[48].addPull(54.65, 31, 115);
            nodes[48].addPull(21.95, 38, 81);
            nodes[48].addPull(39, 40, 48);
            nodes[48].addPull(23.4, 63, 32);
            nodes[48].addPull(45.15, 76, 82);
            nodes[48].addPull(115, 86, 126);
            nodes[48].addPull(121, 88, 168);
            nodes[48].addPull(69.5, 91, 218);
            nodes[49].addPull(37.45, 0, 124);
            nodes[49].addPull(19, 0, 37);
            nodes[49].addPull(43.3, 0, 81);
            nodes[49].addPull(64.85, 121, 216);
            nodes[49].addPull(135.1, 127, 106);
            nodes[49].addPull(85.2, 127, 143);
            nodes[49].addPull(256.8, 130, 178);
            nodes[49].addPull(82.5, 130, 72);
            nodes[49].addPull(108.35, 131, 39);
            nodes[49].addPull(49.55, 160, 39);
            nodes[49].addPull(150.35, 170, 79);
            nodes[49].addPull(85.05, 172, 170);
            nodes[49].addPull(150.1, 175, 130);
            nodes[49].addPull(24.25, 23, 218);
            nodes[49].addPull(75.9, 29, 145);
            nodes[49].addPull(21.6, 2, 183);
            nodes[49].addPull(66.45, 30, 182);
            nodes[49].addPull(67.75, 31, 115);
            nodes[49].addPull(24.7, 38, 81);
            nodes[49].addPull(48.9, 40, 48);
            nodes[49].addPull(26.4, 63, 32);
            nodes[49].addPull(56.1, 76, 82);
            nodes[49].addPull(116.3, 86, 126);
            nodes[49].addPull(110.25, 88, 168);
            nodes[49].addPull(58.8, 91, 218);
            nodes[50].addPull(16.9, 0, 37);
            nodes[50].addPull(34.9, 40, 48);
            nodes[50].addPull(21.35, 63, 32);
            nodes[51].addPull(20.85, 0, 37);
            nodes[51].addPull(38.55, 0, 81);
            nodes[51].addPull(46.25, 31, 115);
            nodes[51].addPull(22.25, 38, 81);
            nodes[51].addPull(53.6, 40, 48);
            nodes[51].addPull(31.55, 63, 32);
            nodes[51].addPull(41.3, 76, 82);
            nodes[52].addPull(37.05, 40, 48);
            nodes[52].addPull(22.65, 63, 32);
            nodes[53].addPull(54.6, 121, 216);
            nodes[53].addPull(127.4, 127, 106);
            nodes[53].addPull(72.2, 127, 143);
            nodes[53].addPull(218.75, 130, 178);
            nodes[53].addPull(85.25, 130, 72);
            nodes[53].addPull(128.05, 131, 39);
            nodes[53].addPull(60.8, 160, 39);
            nodes[53].addPull(171.55, 170, 79);
            nodes[53].addPull(85.05, 172, 170);
            nodes[53].addPull(159.3, 175, 130);
            nodes[53].addPull(47.35, 31, 115);
            nodes[53].addPull(18.7, 38, 81);
            nodes[53].addPull(37.25, 40, 48);
            nodes[53].addPull(26.05, 63, 32);
            nodes[53].addPull(45.15, 76, 82);
            nodes[53].addPull(93.05, 86, 126);
            nodes[54].addPull(76.05, 121, 216);
            nodes[54].addPull(138.6, 127, 106);
            nodes[54].addPull(95.45, 127, 143);
            nodes[54].addPull(326.5, 130, 178);
            nodes[54].addPull(81.55, 130, 72);
            nodes[54].addPull(101.75, 131, 39);
            nodes[54].addPull(59.9, 160, 39);
            nodes[54].addPull(200.35, 170, 79);
            nodes[54].addPull(139.35, 172, 170);
            nodes[54].addPull(234.6, 175, 130);
            nodes[54].addPull(119.35, 180, 220);
            nodes[54].addPull(72.85, 215, 219);
            nodes[54].addPull(136.6, 236, 187);
            nodes[54].addPull(19.45, 38, 81);
            nodes[54].addPull(35.3, 76, 82);
            nodes[54].addPull(97.25, 86, 126);
            nodes[54].addPull(102.6, 88, 168);
            nodes[54].addPull(57, 91, 218);
            nodes[55].addPull(70.45, 121, 216);
            nodes[55].addPull(122.6, 127, 106);
            nodes[55].addPull(87.55, 127, 143);
            nodes[55].addPull(291.15, 130, 178);
            nodes[55].addPull(73.4, 130, 72);
            nodes[55].addPull(95.1, 131, 39);
            nodes[55].addPull(63.25, 160, 39);
            nodes[55].addPull(210.6, 170, 79);
            nodes[55].addPull(143.95, 172, 170);
            nodes[55].addPull(247.7, 175, 130);
            nodes[55].addPull(128.95, 180, 220);
            nodes[55].addPull(84.7, 215, 219);
            nodes[55].addPull(181.7, 236, 187);
            nodes[55].addPull(237.05, 262, 100);
            nodes[55].addPull(70.05, 295, 65);
            nodes[55].addPull(83.7, 86, 126);
            nodes[55].addPull(46.15, 91, 218);
            nodes[56].addPull(64.15, 127, 143);
            nodes[56].addPull(47.2, 160, 39);
            nodes[56].addPull(171.75, 170, 79);
            nodes[56].addPull(113.6, 172, 170);
            nodes[56].addPull(200.9, 175, 130);
            nodes[56].addPull(108.95, 180, 220);
            nodes[56].addPull(81.8, 215, 219);
            nodes[56].addPull(193.05, 236, 187);
            nodes[56].addPull(278.75, 262, 100);
            nodes[56].addPull(80.65, 295, 65);
            nodes[56].addPull(51.6, 297, 53);
            nodes[56].addPull(39.65, 348, 126);
            nodes[56].addPull(48.1, 353, 171);
            nodes[57].addPull(148.85, 175, 130);
            nodes[57].addPull(87.85, 180, 220);
            nodes[57].addPull(70.25, 215, 219);
            nodes[57].addPull(182.45, 236, 187);
            nodes[57].addPull(302.6, 262, 100);
            nodes[57].addPull(84.3, 295, 65);
            nodes[57].addPull(61.6, 297, 53);
            nodes[57].addPull(90.6, 347, 80);
            nodes[57].addPull(55.3, 348, 126);
            nodes[57].addPull(67.8, 353, 171);
            nodes[57].addPull(12.1, 354, 219);
            nodes[58].addPull(56.85, 215, 219);
            nodes[58].addPull(157.15, 236, 187);
            nodes[58].addPull(286.05, 262, 100);
            nodes[58].addPull(79.95, 295, 65);
            nodes[58].addPull(67.25, 297, 53);
            nodes[58].addPull(119.05, 347, 80);
            nodes[58].addPull(73.25, 348, 126);
            nodes[58].addPull(88.6, 353, 171);
            nodes[58].addPull(20.65, 354, 219);
            nodes[59].addPull(213.7, 262, 100);
            nodes[59].addPull(62.35, 295, 65);
            nodes[59].addPull(57.7, 297, 53);
            nodes[59].addPull(127.6, 347, 80);
            nodes[59].addPull(82, 348, 126);
            nodes[59].addPull(93.8, 353, 171);
            nodes[59].addPull(23.75, 354, 219);
            nodes[60].addPull(95.1, 347, 80);
            nodes[60].addPull(66.2, 348, 126);
            nodes[60].addPull(72.85, 353, 171);
            nodes[60].addPull(19.95, 354, 219);
            nodes[61].addPull(30.1, 0, 124);
            nodes[61].addPull(16.25, 0, 37);
            nodes[61].addPull(31.7, 0, 81);
            nodes[61].addPull(69.75, 121, 216);
            nodes[61].addPull(148.35, 127, 106);
            nodes[61].addPull(93.35, 127, 143);
            nodes[61].addPull(290.45, 130, 178);
            nodes[61].addPull(91.95, 130, 72);
            nodes[61].addPull(124.1, 131, 39);
            nodes[61].addPull(61.25, 160, 39);
            nodes[61].addPull(191.75, 170, 79);
            nodes[61].addPull(106.85, 172, 170);
            nodes[61].addPull(196.45, 175, 130);
            nodes[61].addPull(94.6, 180, 220);
            nodes[61].addPull(60.75, 29, 145);
            nodes[61].addPull(58.1, 30, 182);
            nodes[61].addPull(51.4, 31, 115);
            nodes[61].addPull(22.85, 38, 81);
            nodes[61].addPull(40.25, 40, 48);
            nodes[61].addPull(24.25, 63, 32);
            nodes[61].addPull(47.6, 76, 82);
            nodes[61].addPull(110.25, 86, 126);
            nodes[61].addPull(106.5, 88, 168);
            nodes[61].addPull(58.1, 91, 218);
            nodes[62].addPull(32.1, 0, 124);
            nodes[62].addPull(18.25, 0, 37);
            nodes[62].addPull(40.95, 0, 81);
            nodes[62].addPull(123.05, 127, 106);
            nodes[62].addPull(71.75, 127, 143);
            nodes[62].addPull(84.3, 130, 72);
            nodes[62].addPull(120.75, 131, 39);
            nodes[62].addPull(54.7, 160, 39);
            nodes[62].addPull(147.8, 170, 79);
            nodes[62].addPull(21.9, 23, 218);
            nodes[62].addPull(64.4, 29, 145);
            nodes[62].addPull(16.7, 2, 183);
            nodes[62].addPull(54.2, 30, 182);
            nodes[62].addPull(61.85, 31, 115);
            nodes[62].addPull(23.5, 38, 81);
            nodes[62].addPull(50, 40, 48);
            nodes[62].addPull(30.25, 63, 32);
            nodes[62].addPull(55.35, 76, 82);
            nodes[62].addPull(100.8, 86, 126);
            nodes[62].addPull(91.7, 88, 168);
            nodes[62].addPull(48.6, 91, 218);
            nodes[63].addPull(65.6, 130, 72);
            nodes[63].addPull(97.85, 131, 39);
            nodes[63].addPull(40.8, 40, 48);
            nodes[63].addPull(29.9, 63, 32);
            nodes[63].addPull(41.45, 76, 82);
            nodes[64].addPull(72.4, 121, 216);
            nodes[64].addPull(149.1, 127, 106);
            nodes[64].addPull(95.85, 127, 143);
            nodes[64].addPull(302.25, 130, 178);
            nodes[64].addPull(93.45, 130, 72);
            nodes[64].addPull(128.4, 131, 39);
            nodes[64].addPull(72.55, 160, 39);
            nodes[64].addPull(238.15, 170, 79);
            nodes[64].addPull(128.2, 172, 170);
            nodes[64].addPull(242.8, 175, 130);
            nodes[64].addPull(109.9, 180, 220);
            nodes[64].addPull(65.25, 215, 219);
            nodes[64].addPull(130.35, 236, 187);
            nodes[64].addPull(20.9, 63, 32);
            nodes[64].addPull(38.05, 76, 82);
            nodes[64].addPull(101.3, 86, 126);
            nodes[64].addPull(96.3, 88, 168);
            nodes[64].addPull(55.9, 91, 218);
            nodes[65].addPull(88.9, 127, 106);
            nodes[65].addPull(66.3, 130, 72);
            nodes[65].addPull(109.65, 131, 39);
            nodes[65].addPull(52.05, 160, 39);
            nodes[65].addPull(34.25, 76, 82);
            nodes[68].addPull(67.05, 121, 216);
            nodes[68].addPull(132.1, 127, 106);
            nodes[68].addPull(86.7, 127, 143);
            nodes[68].addPull(273.95, 130, 178);
            nodes[68].addPull(83.25, 130, 72);
            nodes[68].addPull(114.75, 131, 39);
            nodes[68].addPull(70.4, 160, 39);
            nodes[68].addPull(245.9, 170, 79);
            nodes[68].addPull(133.35, 172, 170);
            nodes[68].addPull(254.6, 175, 130);
            nodes[68].addPull(117.55, 180, 220);
            nodes[68].addPull(76.1, 215, 219);
            nodes[68].addPull(170.45, 236, 187);
            nodes[68].addPull(262.5, 262, 100);
            nodes[68].addPull(81.95, 295, 65);
            nodes[68].addPull(86.9, 86, 126);
            nodes[68].addPull(49.8, 91, 218);
            nodes[69].addPull(121.75, 127, 106);
            nodes[69].addPull(71.05, 127, 143);
            nodes[69].addPull(208.45, 130, 178);
            nodes[69].addPull(82.45, 130, 72);
            nodes[69].addPull(121.85, 131, 39);
            nodes[69].addPull(70.4, 160, 39);
            nodes[69].addPull(200.8, 170, 79);
            nodes[69].addPull(92.2, 172, 170);
            nodes[69].addPull(180.55, 175, 130);
            nodes[69].addPull(83.45, 180, 220);
            nodes[69].addPull(34.2, 76, 82);
            nodes[69].addPull(79.35, 86, 126);
            nodes[70].addPull(66, 130, 72);
            nodes[70].addPull(105.25, 131, 39);
            nodes[70].addPull(57.1, 160, 39);
            nodes[70].addPull(152.65, 170, 79);
            nodes[71].addPull(94, 127, 106);
            nodes[71].addPull(62.85, 127, 143);
            nodes[71].addPull(80.5, 131, 39);
            nodes[71].addPull(54.75, 160, 39);
            nodes[71].addPull(190.3, 170, 79);
            nodes[71].addPull(103.75, 172, 170);
            nodes[71].addPull(196.65, 175, 130);
            nodes[71].addPull(96.25, 180, 220);
            nodes[71].addPull(72.5, 215, 219);
            nodes[71].addPull(168.55, 236, 187);
            nodes[71].addPull(300.25, 262, 100);
            nodes[71].addPull(94.75, 295, 65);
            nodes[71].addPull(60.15, 297, 53);
            nodes[71].addPull(69, 347, 80);
            nodes[71].addPull(47.7, 353, 171);
            nodes[72].addPull(42.8, 160, 39);
            nodes[72].addPull(141.75, 170, 79);
            nodes[72].addPull(148.5, 175, 130);
            nodes[72].addPull(62, 215, 219);
            nodes[72].addPull(160.3, 236, 187);
            nodes[72].addPull(332.35, 262, 100);
            nodes[72].addPull(103.05, 295, 65);
            nodes[72].addPull(74.05, 297, 53);
            nodes[72].addPull(102.4, 347, 80);
            nodes[72].addPull(54.95, 348, 126);
            nodes[72].addPull(64.3, 353, 171);
            nodes[72].addPull(11.5, 354, 219);
            nodes[73].addPull(140.1, 236, 187);
            nodes[73].addPull(322.95, 262, 100);
            nodes[73].addPull(96.4, 295, 65);
            nodes[73].addPull(80.25, 297, 53);
            nodes[73].addPull(140.75, 347, 80);
            nodes[73].addPull(71.9, 348, 126);
            nodes[73].addPull(77.7, 353, 171);
            nodes[73].addPull(17.35, 354, 219);
            nodes[74].addPull(234.9, 262, 100);
            nodes[74].addPull(74.95, 295, 65);
            nodes[74].addPull(73.75, 297, 53);
            nodes[74].addPull(164, 347, 80);
            nodes[74].addPull(82.95, 348, 126);
            nodes[74].addPull(81.75, 353, 171);
            nodes[74].addPull(19.6, 354, 219);
            nodes[75].addPull(49.25, 297, 53);
            nodes[75].addPull(139.5, 347, 80);
            nodes[75].addPull(70.3, 348, 126);
            nodes[75].addPull(63.25, 353, 171);
            nodes[75].addPull(15.8, 354, 219);
            nodes[77].addPull(80.6, 131, 39);
            nodes[77].addPull(53.6, 160, 39);
            nodes[77].addPull(150.9, 170, 79);
            nodes[78].addPull(104.3, 127, 106);
            nodes[78].addPull(65.5, 127, 143);
            nodes[78].addPull(72.25, 130, 72);
            nodes[78].addPull(104.3, 131, 39);
            nodes[78].addPull(67.2, 160, 39);
            nodes[78].addPull(206.2, 170, 79);
            nodes[78].addPull(96.35, 172, 170);
            nodes[78].addPull(187.55, 175, 130);
            nodes[78].addPull(84.7, 180, 220);
            nodes[78].addPull(120.05, 236, 187);
            nodes[78].addPull(212.7, 262, 100);
            nodes[78].addPull(75.35, 295, 65);
            nodes[79].addPull(53.6, 160, 39);
            nodes[79].addPull(172.7, 170, 79);
            nodes[79].addPull(162.35, 175, 130);
            nodes[79].addPull(127.7, 236, 187);
            nodes[79].addPull(261.25, 262, 100);
            nodes[79].addPull(96, 295, 65);
            nodes[79].addPull(59.75, 297, 53);
            nodes[80].addPull(72.2, 295, 65);
            nodes[80].addPull(46.1, 297, 53);
            nodes[84].addPull(214.9, 262, 100);
            nodes[84].addPull(90.7, 295, 65);
            nodes[84].addPull(64.4, 297, 53);
            nodes[84].addPull(84.3, 347, 80);
            nodes[85].addPull(297.8, 262, 100);
            nodes[85].addPull(101.7, 295, 65);
            nodes[85].addPull(73.6, 297, 53);
            nodes[85].addPull(98.55, 347, 80);
            nodes[85].addPull(46.1, 348, 126);
            nodes[85].addPull(48.95, 353, 171);
            nodes[86].addPull(277.85, 262, 100);
            nodes[86].addPull(95.45, 295, 65);
            nodes[86].addPull(86.2, 297, 53);
            nodes[86].addPull(135.15, 347, 80);
            nodes[86].addPull(58.55, 348, 126);
            nodes[86].addPull(59.35, 353, 171);
            nodes[87].addPull(203.05, 262, 100);
            nodes[87].addPull(80.8, 295, 65);
            nodes[87].addPull(80.6, 297, 53);
            nodes[87].addPull(113.35, 347, 80);
            nodes[87].addPull(43.65, 348, 126);
            nodes[89].addPull(74.1, 347, 80);
            nodes[91].addPull(58.8, 295, 65);
            nodes[91].addPull(75.35, 297, 53);
            nodes[91].addPull(137.4, 347, 80);
            nodes[91].addPull(47.3, 348, 126);
            nodes[92].addPull(49.3, 297, 53);
            nodes[92].addPull(127.8, 347, 80);
            nodes[93].addPull(214.7, 262, 100);
            nodes[93].addPull(72.7, 295, 65);
            nodes[93].addPull(80.65, 297, 53);
            nodes[93].addPull(169.95, 347, 80);
            nodes[93].addPull(64.55, 348, 126);
            nodes[93].addPull(58.65, 353, 171);
            nodes[93].addPull(14.8, 354, 219);
            nodes[94].addPull(49.95, 297, 53);
            nodes[94].addPull(149.1, 347, 80);
            nodes[94].addPull(50.7, 348, 126);
            nodes[94].addPull(11.25, 354, 219);




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawLine(System.Drawing.Pens.Red, panel1.Left, panel1.Top,
                panel1.Right, panel1.Bottom);



            // 'World' coordinates are (220,360)
            // g.FillEllipse(b,x,y,w,h);
            // panel1.Height;
            SolidBrush b = new SolidBrush(Color.Black);
            Rectangle r = new Rectangle();
            foreach(Node n in nodes)
            {
                if (n.pulls.Count == 0) continue;

                r.X = (n.x * panel1.Width) / 360;
                r.Y = (n.y * panel1.Height) / 220;
                r.Height = 5;
                r.Width = 5;
                g.FillEllipse(b, r);



                foreach(pull p in n.pulls)
                {

                    g.DrawLine(System.Drawing.Pens.DarkOrange, 
                        (n.x * panel1.Width) / 360,
                        (n.y * panel1.Height) / 220,
                        (p.x * panel1.Width) / 360,
                        (p.y * panel1.Height) / 220
                        );

                    g.DrawEllipse(System.Drawing.Pens.DarkViolet,
                        (p.x * panel1.Width) / 360 - 3,
                        (p.y * panel1.Height) / 220 - 3,
                        6,6
                        );
                }

                g.DrawString(string.Format("{0}", n.label),
                new Font("Arial", 10), System.Drawing.Brushes.Blue, r.X, r.Y);
            }
            //g.FillEllipse(b, 50, 50, 3, 3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Node n in nodes)
            {
                if (n.pulls.Count() == 0) continue;

                Vector resultant = new Vector(0,0);
                foreach (pull p in n.pulls)
                {

                    Vector v = new Vector(p.x - n.x, p.y - n.y);
                    v.Normalize();
                    Vector.Multiply(v, p.force);
                    resultant = Vector.Add(resultant, v);
                }

                System.Windows.Point point = new System.Windows.Point(n.x, n.y);
                point = Vector.Add(resultant, point);

                try
                {
                    n.x = Convert.ToInt32(point.X);
                    n.y = Convert.ToInt32(point.Y);
                }
                catch (System.OverflowException soee)
                {

                }


                textBox1.AppendText(string.Format("{0:N3},{1:N3}", n.x, n.y) + Environment.NewLine);

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
this.Refresh();
        }
    }
}
