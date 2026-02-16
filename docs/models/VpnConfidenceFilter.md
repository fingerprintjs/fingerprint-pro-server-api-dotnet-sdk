# Fingerprint.ServerSdk.Model.VpnConfidenceFilter
Filter events by VPN Detection result confidence level.
`high` - events with high VPN Detection confidence.
`medium` - events with medium VPN Detection confidence.
`low` - events with low VPN Detection confidence.
> Note: When using this parameter, only events with the `vpn.confidence` property set to a valid value are returned. Events without a `vpn` Smart Signal result are left out of the response.

