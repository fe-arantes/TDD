﻿using LeilaoOnline.Core.Entidade;

var leilao = new Leilao("Van Gogh");
var fulano = new Interessada("Fulano", leilao);
var maria = new Interessada("Maria", leilao);

leilao.RecebeLance(fulano, 800);
leilao.RecebeLance(maria, 900);
leilao.RecebeLance(fulano, 1000);

leilao.TerminaPregao();

Console.WriteLine(leilao.Ganhador.Valor);
Console.ReadKey();