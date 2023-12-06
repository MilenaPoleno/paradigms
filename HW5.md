sum_arr([], 0).
sum_arr([Head|Tail], Sum) :-
   sum_arr(Tail, Rest),
   Sum is Head + Rest.
