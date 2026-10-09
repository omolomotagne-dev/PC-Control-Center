# Architecture
- App/UI : WPF, thème et navigation.
- Contracts : contrats des modules, métriques et états.
- Platform adapters à ajouter : API Windows, compteurs, WMI si disponible, capteurs matériels.
- Data à ajouter : configuration JSON et historique SQLite.
- Modules à ajouter : inventaire, santé, gaming, maintenance.

Les modules ne dépendent pas les uns des autres. Collectes annulables, aucune collecte simultanée, erreurs isolées. Une valeur absente reste nulle et sa qualité indique Unavailable, Stale ou Error.
