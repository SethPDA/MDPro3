using System.Collections.Generic;

namespace YgomSystem.Network
{
	public class API
	{
		public static Handle System_info()
		{
			return null;
		}

		public static Handle System_set_language(string _lang_)
		{
			return null;
		}

		public static Handle System_toggle_crossplay()
		{
			return null;
		}

		public static Handle Account_create(int _agreement_type_, string[] _agree_info_, int _country_, Dictionary<string, object> _enquete_results_)
		{
			return null;
		}

		public static Handle Account_create(string _auth_session_, int _agreement_type_, string[] _agree_info_, int _country_, Dictionary<string, object> _enquete_results_)
		{
			return null;
		}

		public static Handle Account_auth()
		{
			return null;
		}

		public static Handle Account_auth(string _auth_session_, bool _valid_steam_overlay_)
		{
			return null;
		}

		public static Handle Account_auth(string _auth_session_)
		{
			return null;
		}

		public static Handle Account_auth(string _auth_session_, int _label_)
		{
			return null;
		}

		public static Handle Account_re_agree(string[] _agree_info_, bool _optout_)
		{
			return null;
		}

		public static Handle Account_is_regist_platform()
		{
			return null;
		}

		public static Handle Account_regist_platform()
		{
			return null;
		}

		public static Handle Account_inherit_platform()
		{
			return null;
		}

		public static Handle Account_kid_get_link_url()
		{
			return null;
		}

		public static Handle Account_kid_check_linked()
		{
			return null;
		}

		public static Handle Account_kid_get_inherit_url()
		{
			return null;
		}

		public static Handle Account_kid_check_inherited(string _kid_inherit_nonce_, string _auth_session_)
		{
			return null;
		}

		public static Handle Account_kid_get_neuron_token()
		{
			return null;
		}

		public static Handle Account_set_opt_out()
		{
			return null;
		}

		public static Handle Account_report_user(int _reported_pcode_, int[] _report_ids_)
		{
			return null;
		}

		public static Handle Account_unlock(string _pass_)
		{
			return null;
		}

		public static Handle Account_set_official_settings()
		{
			return null;
		}

		public static Handle Account_Steam_get_user_id(string _session_ticket_)
		{
			return null;
		}

		public static Handle Account_Steam_re_auth(string _session_ticket_)
		{
			return null;
		}

		public static Handle Account_PS_get_user_id(string _auth_session_)
		{
			return null;
		}

		public static Handle Account_PS_re_auth(string _auth_session_)
		{
			return null;
		}

		public static Handle Account_PS_refresh_auth(string _auth_session_)
		{
			return null;
		}

		public static Handle Account_XBox_get_user_id(string _auth_session_)
		{
			return null;
		}

		public static Handle Account_XBox_re_auth(string _auth_session_)
		{
			return null;
		}

		public static Handle Account_XBox_refresh_auth(string _auth_session_)
		{
			return null;
		}

		public static Handle Account_Nx_get_user_id(string _auth_session_)
		{
			return null;
		}

		public static Handle Account_Nx_re_auth(string _auth_session_)
		{
			return null;
		}

		public static Handle Account_Nx_refresh_auth(string _auth_session_)
		{
			return null;
		}

		public static Handle User_entry()
		{
			return null;
		}

		public static Handle User_home()
		{
			return null;
		}

		public static Handle User_profile(long _pcode_)
		{
			return null;
		}

		public static Handle User_record(long _pcode_)
		{
			return null;
		}

		public static Handle User_set_profile(Dictionary<string, object> _param_)
		{
			return null;
		}

		public static Handle User_replay_list(long _pcode_)
		{
			return null;
		}

		public static Handle User_first_name_entry(string _name_)
		{
			return null;
		}

		public static Handle User_name_entry(string _name_)
		{
			return null;
		}

		public static Handle User_complete_home_guide()
		{
			return null;
		}

		public static Handle User_item_get_history()
		{
			return null;
		}

		public static Handle Duel_begin(Dictionary<string, object> _rule_)
		{
			return null;
		}

		public static Handle Duel_end(Dictionary<string, object> _params_)
		{
			return null;
		}

		public static Handle Duel_matching(Dictionary<string, object> _rule_)
		{
			return null;
		}

		public static Handle Duel_matching_cancel()
		{
			return null;
		}

		public static Handle Duel_start_waiting()
		{
			return null;
		}

		public static Handle Duel_start_selecting(int _select_)
		{
			return null;
		}

		public static Handle Duel_team_matching_leader(Dictionary<string, object> _rule_)
		{
			return null;
		}

		public static Handle Duel_team_matching_member(Dictionary<string, object> _rule_)
		{
			return null;
		}

		public static Handle Tournament_info()
		{
			return null;
		}

		public static Handle Tournament_entry(int _tid_)
		{
			return null;
		}

		public static Handle Tournament_detail(int _tid_)
		{
			return null;
		}

		public static Handle Tournament_reward_list(int _tid_)
		{
			return null;
		}

		public static Handle Tournament_duel_history(int _tid_)
		{
			return null;
		}

		public static Handle Tournament_ranking(int _tid_)
		{
			return null;
		}

		public static Handle Tournament_get_deck_list(int _tid_, bool _is_empty_get_)
		{
			return null;
		}

		public static Handle Tournament_set_deck(int _tid_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
		{
			return null;
		}

		public static Handle Tournament_set_deck_accessory(int _tid_, Dictionary<string, object> _param_)
		{
			return null;
		}

		public static Handle Tournament_delete_deck(int _tid_)
		{
			return null;
		}

		public static Handle Deck_get_deck()
		{
			return null;
		}

		public static Handle Deck_get_deck_list(int _deck_id_, bool _is_empty_get_)
		{
			return null;
		}

		public static Handle Deck_update_deck(int _deck_id_, string _name_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _pick_cards_, Dictionary<string, object> _accessory_)
		{
			return null;
		}

		public static Handle Deck_update_deck_reg(int _deck_id_, string _name_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _pick_cards_, Dictionary<string, object> _accessory_, int _regulation_id_)
		{
			return null;
		}

		public static Handle Deck_delete_deck(int _deck_id_)
		{
			return null;
		}

		public static Handle Deck_delete_deck_multi(int[] _deck_id_list_)
		{
			return null;
		}

		public static Handle Deck_check_deck_regulation(int _deck_id_, int _regulation_id_)
		{
			return null;
		}

		public static Handle Deck_set_deck_accessory(int _deck_id_, Dictionary<string, object> _param_)
		{
			return null;
		}

		public static Handle Deck_set_select_deck(int _mode_, int _deck_id_)
		{
			return null;
		}

		public static Handle Deck_CopyStructure(int _structure_id_)
		{
			return null;
		}

		public static Handle Deck_SetFavoriteCards(Dictionary<string, object> _card_list_)
		{
			return null;
		}

		public static Handle Deck_ExportDeck(string _N_token_, int _deck_id_)
		{
			return null;
		}

		public static Handle Deck_GetAccessoryDetail()
		{
			return null;
		}

		public static Handle Download_begin()
		{
			return null;
		}

		public static Handle Download_complete()
		{
			return null;
		}

		public static Handle Download_progress(string _dl_end_)
		{
			return null;
		}

		public static Handle Craft_exchange(int _card_id_)
		{
			return null;
		}

		public static Handle Craft_exchange_multi(Dictionary<string, object> _card_list_, int[] _compensation_list_)
		{
			return null;
		}

		public static Handle Craft_generate(int _card_id_)
		{
			return null;
		}

		public static Handle Craft_generate_multi(Dictionary<string, object> _card_list_)
		{
			return null;
		}

		public static Handle Craft_get_card_route(int _card_id_)
		{
			return null;
		}

		public static Handle Friend_follow(long _pcode_, int _delete_)
		{
			return null;
		}

		public static Handle Friend_set_pin(long _pcode_, int _delete_, int _update_work_)
		{
			return null;
		}

		public static Handle Friend_get_follower(long _date_, long _pcode_, int _dir_)
		{
			return null;
		}

		public static Handle Friend_get_list(bool _all_)
		{
			return null;
		}

		public static Handle Friend_id_search(long _pcode_)
		{
			return null;
		}

		public static Handle Friend_tag_search(int[] _tag_)
		{
			return null;
		}

		public static Handle Friend_block(long _pcode_, int _delete_)
		{
			return null;
		}

		public static Handle Friend_refresh_info(long[] _pcode_list_)
		{
			return null;
		}

		public static Handle Mission_get_list()
		{
			return null;
		}

		public static Handle Mission_receive(int _pool_id_, int _mission_id_, int _goal_pos_)
		{
			return null;
		}

		public static Handle Mission_bulk_receive(int[] _bulk_pool_id_, int[] _bulk_mission_id_, int[] _bulk_goal_pos_)
		{
			return null;
		}

		public static Handle PvP_watch_duel(long _pcode_, long _rapid_)
		{
			return null;
		}

		public static Handle PvP_replay_duel(long _pcode_, long _did_)
		{
			return null;
		}

		public static Handle PvP_save_replay(int _mode_, long _did_, int _eid_)
		{
			return null;
		}

		public static Handle PvP_remove_replay(long _did_)
		{
			return null;
		}

		public static Handle PvP_replay_duel_history(int _idx_, int _mode_, long _did_, int _eid_)
		{
			return null;
		}

		public static Handle PvP_replay_duel_history_with_room(long _did_, long _pcode_)
		{
			return null;
		}

		public static Handle PvP_duel_history(int _mode_)
		{
			return null;
		}

		public static Handle PvP_set_replay_open(long _did_, bool _open_)
		{
			return null;
		}

		public static Handle PvP_get_history_deck(long _did_, int _mode_, int _idx_)
		{
			return null;
		}

		public static Handle PvP_get_replay_deck(long _did_)
		{
			return null;
		}

		public static Handle Structure_first(int _structure_id_)
		{
			return null;
		}

		public static Handle Structure_check_have_structure()
		{
			return null;
		}

		public static Handle Gacha_get_card_list(int _card_list_id_)
		{
			return null;
		}

		public static Handle Gacha_get_probability(int _gacha_id_, int _shop_id_)
		{
			return null;
		}

		public static Handle Shop_get_list(int _category_)
		{
			return null;
		}

		public static Handle Shop_purchase(int _shop_id_, int _price_id_, int _count_, Dictionary<string, object> _args_)
		{
			return null;
		}

		public static Handle Shop_visit(int[] _shop_ids_)
		{
			return null;
		}

		public static Handle Challenge_detail(int _mode_, int _season_id_)
		{
			return null;
		}

		public static Handle Challenge_ranking(int _mode_, int _season_id_)
		{
			return null;
		}

		public static Handle Challenge_set_deck(int _mode_, int _deck_id_)
		{
			return null;
		}

		public static Handle Challenge_duel_history(int _mode_, int _season_id_)
		{
			return null;
		}

		public static Handle Challenge_reward_list(int _mode_, int _season_id_)
		{
			return null;
		}

		public static Handle Casual_detail()
		{
			return null;
		}

		public static Handle Casual_duel_history()
		{
			return null;
		}

		public static Handle Solo_info(bool _back_)
		{
			return null;
		}

		public static Handle Solo_detail(int _chapter_)
		{
			return null;
		}

		public static Handle Solo_start(int _chapter_)
		{
			return null;
		}

		public static Handle Solo_deck_check()
		{
			return null;
		}

		public static Handle Solo_set_use_deck_type(int _chapter_, int _deck_type_)
		{
			return null;
		}

		public static Handle Solo_skip(int _chapter_)
		{
			return null;
		}

		public static Handle Solo_gate_entry(int _gate_)
		{
			return null;
		}

		public static Handle PresentBox_get_list()
		{
			return null;
		}

		public static Handle PresentBox_receive(int _present_box_id_, int _is_all_)
		{
			return null;
		}

		public static Handle DuelMenu_info()
		{
			return null;
		}

		public static Handle DuelMenu_deck_check(int _kind_, int _tid_, int _regulation_id_)
		{
			return null;
		}

		public static Handle Notification_get_list()
		{
			return null;
		}

		public static Handle Notification_read(int _id_)
		{
			return null;
		}

		public static Handle EventNotify_get_list()
		{
			return null;
		}

		public static Handle EventNotify_delete_badge(int _type_, int _subtype_, int[] _target_list_)
		{
			return null;
		}

		public static Handle Billing_product_list()
		{
			return null;
		}

		public static Handle Billing_reservation(int _shop_id_, int _merchID_, string _price_, string _currency_)
		{
			return null;
		}

		public static Handle Billing_Nx_reservation(int _merchID_, string _price_, string _currency_)
		{
			return null;
		}

		public static Handle Billing_XBox_reservation(int _merchID_, string _price_, string _currency_)
		{
			return null;
		}

		public static Handle Billing_PS_reservation(int _merchID_, string _price_, string _currency_)
		{
			return null;
		}

		public static Handle Billing_purchase(string _receipt_, string _adid_, string _idfa_, string _idfv_, string _gps_adid_)
		{
			return null;
		}

		public static Handle Billing_purchase(string _receipt_, string _orderid_, string _transactionid_)
		{
			return null;
		}

		public static Handle Billing_Nx_purchase()
		{
			return null;
		}

		public static Handle Billing_XBox_purchase()
		{
			return null;
		}

		public static Handle Billing_PS_purchase()
		{
			return null;
		}

		public static Handle Billing_cancel()
		{
			return null;
		}

		public static Handle Billing_re_store(string _receipt_)
		{
			return null;
		}

		public static Handle Billing_Steam_re_store(long _orderid_, long _transactionid_)
		{
			return null;
		}

		public static Handle Billing_Nx_re_store()
		{
			return null;
		}

		public static Handle Billing_XBox_re_store(string _tracking_id_, int _merchID_, string _product_id_, string _price_, string _currency_, bool _is_un_complete_add_item_)
		{
			return null;
		}

		public static Handle Billing_PS_re_store(string _transaction_id_, int _merchID_, string _product_id_, string _entitlement_label_, string _price_, string _currency_, bool _is_un_complete_add_item_)
		{
			return null;
		}

		public static Handle Billing_PS_add_incentive_item(string _transaction_id_, int _ps_incentive_id_, string _product_id_, string _entitlement_label_, int _service_label_)
		{
			return null;
		}

		public static Handle Billing_register_age(int _age_reg_id_)
		{
			return null;
		}

		public static Handle Billing_add_purchased_item()
		{
			return null;
		}

		public static Handle Billing_in_complete_item_check()
		{
			return null;
		}

		public static Handle Billing_Steam_in_complete_item_check()
		{
			return null;
		}

		public static Handle Billing_Nx_in_complete_item_check()
		{
			return null;
		}

		public static Handle Billing_XBox_in_complete_item_check()
		{
			return null;
		}

		public static Handle Billing_PS_in_complete_item_check()
		{
			return null;
		}

		public static Handle Billing_history(string _month_, int _page_, int _page_count_)
		{
			return null;
		}

		public static Handle Cgdb_deck_search_init()
		{
			return null;
		}

		public static Handle Cgdb_deck_search(int _typeCode_, int[] _categoryList_, int[] _tagList_, int[] _cardIdList_, string _keyword_, int _sortCode_, int _sizePerPage_, int _requestPageNo_)
		{
			return null;
		}

		public static Handle Cgdb_deck_search_detail(string _targetId_, int _deckNo_)
		{
			return null;
		}

		public static Handle Cgdb_mydeck_search(string _userToken_, int _sortCode_, int _sizePerPage_, int _requestPageNo_)
		{
			return null;
		}

		public static Handle Cgdb_mydeck_search_detail(string _userToken_, int _deckNo_)
		{
			return null;
		}

		public static Handle Room_room_create(Dictionary<string, object> _room_settings_)
		{
			return null;
		}

		public static Handle Room_room_create(Dictionary<string, object> _room_settings_, string _context_id_)
		{
			return null;
		}

		public static Handle Room_room_entry(int _id_, int _is_specter_, Dictionary<string, object> _options_)
		{
			return null;
		}

		public static Handle Room_room_entry(int _id_, int _is_specter_, Dictionary<string, object> _options_, string _context_id_)
		{
			return null;
		}

		public static Handle Room_room_exit()
		{
			return null;
		}

		public static Handle Room_get_room_list(Dictionary<string, object> _search_options_)
		{
			return null;
		}

		public static Handle Room_table_arrive(int _table_no_)
		{
			return null;
		}

		public static Handle Room_table_leave()
		{
			return null;
		}

		public static Handle Room_room_friend_invite(long[] _invite_list_)
		{
			return null;
		}

		public static Handle Room_room_friend_invite(long[] _invite_list_, string _context_id_)
		{
			return null;
		}

		public static Handle Room_room_table_polling()
		{
			return null;
		}

		public static Handle Room_is_room_battle_ready(bool _isBattleReady_, long _opp_pcode_)
		{
			return null;
		}

		public static Handle Room_set_user_comment(int _comment_id_)
		{
			return null;
		}

		public static Handle Room_get_result_list()
		{
			return null;
		}

		public static Handle Exhibition_detail(int _exhid_)
		{
			return null;
		}

		public static Handle Exhibition_duel_history(int _exhid_)
		{
			return null;
		}

		public static Handle Exhibition_set_deck(int _exhid_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
		{
			return null;
		}

		public static Handle Exhibition_set_deck_accessory(int _exhid_, Dictionary<string, object> _param_)
		{
			return null;
		}

		public static Handle Exhibition_delete_deck(int _exhid_)
		{
			return null;
		}

		public static Handle Exhibition_copy_to_deck(int _exhid_)
		{
			return null;
		}

		public static Handle Exhibition_rental_deck_detail(int _exhid_, int _rental_idx_)
		{
			return null;
		}

		public static Handle Exhibition_copy_rental_deck(int _exhid_, int _rental_idx_)
		{
			return null;
		}

		public static Handle Exhibition_set_use_deck(int _exhid_, int _rental_idx_)
		{
			return null;
		}

		public static Handle Exhibition_get_deck_list(int _exhid_, bool _is_empty_get_)
		{
			return null;
		}

		public static Handle Duelpass_get_info()
		{
			return null;
		}

		public static Handle Duelpass_bulk_receive(int _season_id_, int[] _reward_id_list_)
		{
			return null;
		}

		public static Handle DuelLive_replay_list(int _menu_id_, int _section_id_)
		{
			return null;
		}

		public static Handle DuelLive_replay_duel(int _menu_id_, int _idx_)
		{
			return null;
		}

		public static Handle Enquete_get_questions(int _enquete_id_)
		{
			return null;
		}

		public static Handle Enquete_send_answers(int _enquete_id_, Dictionary<string, object> _results_)
		{
			return null;
		}

		public static Handle RankEvent_detail(int _rank_event_id_)
		{
			return null;
		}

		public static Handle RankEvent_duel_history(int _rank_event_id_)
		{
			return null;
		}

		public static Handle RankEvent_reward_list(int _rank_event_id_)
		{
			return null;
		}

		public static Handle RankEvent_get_deck_list(int _rank_event_id_, bool _is_empty_get_)
		{
			return null;
		}

		public static Handle RankEvent_set_deck(int _rank_event_id_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
		{
			return null;
		}

		public static Handle RankEvent_set_deck_accessory(int _rank_event_id_, Dictionary<string, object> _param_)
		{
			return null;
		}

		public static Handle RankEvent_delete_deck(int _rank_event_id_)
		{
			return null;
		}

		public static Handle Cup_detail(int _cid_)
		{
			return null;
		}

		public static Handle Cup_get_deck_list(int _cid_, bool _is_empty_get_)
		{
			return null;
		}

		public static Handle Cup_set_deck(int _cid_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
		{
			return null;
		}

		public static Handle Cup_delete_deck(int _cid_)
		{
			return null;
		}

		public static Handle Cup_duel_history(int _cid_)
		{
			return null;
		}

		public static Handle Cup_set_deck_accessory(int _cid_, Dictionary<string, object> _param_)
		{
			return null;
		}

		public static Handle Cup_get_ranking(int _cid_)
		{
			return null;
		}

		public static Handle CardTermData_get_list()
		{
			return null;
		}

		public static Handle Team_set_team_regulation_group_id(int _team_regulation_group_id_)
		{
			return null;
		}

		public static Handle Team_team_create(Dictionary<string, object> _team_settings_, int _team_match_type_)
		{
			return null;
		}

		public static Handle Team_team_create(Dictionary<string, object> _team_settings_, int _team_match_type_, string _context_id_)
		{
			return null;
		}

		public static Handle Team_team_exit()
		{
			return null;
		}

		public static Handle Team_team_entry(int _team_id_, int _team_match_type_)
		{
			return null;
		}

		public static Handle Team_team_entry(int _team_id_, int _team_match_type_, string _context_id_)
		{
			return null;
		}

		public static Handle Team_team_entry_and_arrive(int _team_id_, int _team_match_type_, int _table_no_)
		{
			return null;
		}

		public static Handle Team_team_entry_and_arrive(int _team_id_, int _team_match_type_, string _context_id_, int _table_no_)
		{
			return null;
		}

		public static Handle Team_team_invite(long[] _invite_list_)
		{
			return null;
		}

		public static Handle Team_team_invite(long[] _invite_list_, string _context_id_)
		{
			return null;
		}

		public static Handle Team_team_recruit(int _num_)
		{
			return null;
		}

		public static Handle Team_team_search(int _num_, bool _cancel_flg_)
		{
			return null;
		}

		public static Handle Team_team_polling(int _team_match_type_)
		{
			return null;
		}

		public static Handle Team_team_result_polling()
		{
			return null;
		}

		public static Handle Team_table_arrive(int _table_no_)
		{
			return null;
		}

		public static Handle Team_table_leave()
		{
			return null;
		}

		public static Handle Team_post_comment(int _comment_id_)
		{
			return null;
		}

		public static Handle Team_team_duel_request(int _team_id_, int _duel_time_)
		{
			return null;
		}

		public static Handle Team_team_duel_request_cancel()
		{
			return null;
		}

		public static Handle Team_team_duel_reply(bool _reply_)
		{
			return null;
		}

		public static Handle LoginBonus_get_info(int _login_bonus_id_)
		{
			return null;
		}

		public static Handle LoginBonus_get_list()
		{
			return null;
		}

		public static Handle LoginBonus_receive(int _login_bonus_id_)
		{
			return null;
		}

		public static Handle DuelTrial_detail(int _duel_trial_id_)
		{
			return null;
		}

		public static Handle DuelTrial_duel_history(int _duel_trial_id_)
		{
			return null;
		}

		public static Handle DuelTrial_get_deck_list(int _duel_trial_id_, int _idx_, bool _is_empty_get_)
		{
			return null;
		}

		public static Handle DuelTrial_set_deck(int _duel_trial_id_, int _idx_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
		{
			return null;
		}

		public static Handle DuelTrial_set_deck_accessory(int _duel_trial_id_, int _idx_, Dictionary<string, object> _param_)
		{
			return null;
		}

		public static Handle DuelTrial_delete_deck(int _duel_trial_id_, int _idx_)
		{
			return null;
		}

		public static Handle DuelTrial_set_use_deck(int _duel_trial_id_, int _rental_idx_)
		{
			return null;
		}

		public static Handle DuelTrial_get_rental_deck_list(int _duel_trial_id_, int _rental_idx_)
		{
			return null;
		}

		public static Handle DuelTrial_receive_bonus(int _duel_trial_id_, int _item_id_, int _num_)
		{
			return null;
		}

		public static Handle PromoCodes_send_code(int _promo_codes_id_, string _send_code_, string _check_code_)
		{
			return null;
		}

		public static Handle Wcs_detail(int _wcs_id_)
		{
			return null;
		}

		public static Handle Wcs_get_deck_list(int _wcs_id_, bool _is_empty_get_)
		{
			return null;
		}

		public static Handle Wcs_set_deck(int _wcs_id_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
		{
			return null;
		}

		public static Handle Wcs_delete_deck(int _wcs_id_)
		{
			return null;
		}

		public static Handle Wcs_duel_history(int _wcs_id_)
		{
			return null;
		}

		public static Handle Wcs_set_deck_accessory(int _wcs_id_, Dictionary<string, object> _param_)
		{
			return null;
		}

		public static Handle Wcs_get_ranking(int _wcs_id_)
		{
			return null;
		}

		public static Handle Wcs_set_region(int _wcs_id_, int _region_)
		{
			return null;
		}

		public static Handle Wcs_get_participation()
		{
			return null;
		}

		public static Handle Wcs_confirm_participation(int _id_)
		{
			return null;
		}

		public static Handle Wcs_get_final_deck_info()
		{
			return null;
		}

		public static Handle Wcs_set_final_deck(int _wcs_id_, int _member_idx_, int _slot_, string _name_, Dictionary<string, object> _deck_list_)
		{
			return null;
		}

		public static Handle Wcs_delete_final_deck(int _wcs_id_, int _member_idx_, int _slot_)
		{
			return null;
		}

		public static Handle Wcs_set_final_share_card(int _wcs_id_, Dictionary<string, object> _share_cards_)
		{
			return null;
		}

		public static Handle Wcs_check_final_deck_regulation(int _wcs_id_)
		{
			return null;
		}

		public static Handle Wcs_complete_final_deck(int _wcs_id_)
		{
			return null;
		}

		public static Handle Wcs_unregister_final_deck(int _wcs_id_)
		{
			return null;
		}

		public static Handle Versus_detail(int _versus_id_, int _set_group_id_)
		{
			return null;
		}

		public static Handle Versus_duel_history(int _versus_id_)
		{
			return null;
		}

		public static Handle Versus_get_deck_list(int _versus_id_, int _idx_, bool _is_empty_get_)
		{
			return null;
		}

		public static Handle Versus_set_deck(int _versus_id_, int _idx_, Dictionary<string, object> _deck_list_, Dictionary<string, object> _accessory_, Dictionary<string, object> _pick_cards_)
		{
			return null;
		}

		public static Handle Versus_set_deck_accessory(int _versus_id_, int _idx_, Dictionary<string, object> _param_)
		{
			return null;
		}

		public static Handle Versus_delete_deck(int _versus_id_, int _idx_)
		{
			return null;
		}

		public static Handle Versus_set_use_deck(int _versus_id_, int _rental_idx_)
		{
			return null;
		}

		public static Handle Versus_get_rental_deck_list(int _versus_id_, int _rental_idx_)
		{
			return null;
		}

		public static Handle WcsFinal_table_polling()
		{
			return null;
		}

		public static Handle WcsFinal_is_duel_ready(bool _isReady_, long _opp_pcode_)
		{
			return null;
		}

		public static Handle WcsFinal_admin_table_polling(int _room_id_)
		{
			return null;
		}

		public static Handle WcsFinal_admin_primary_polling()
		{
			return null;
		}

		public static Handle WcsFinal_admin_final_polling()
		{
			return null;
		}

		public static Handle WcsfCampaign_info()
		{
			return null;
		}

		public static Handle WcsfCampaign_primary_polling()
		{
			return null;
		}

		public static Handle WcsfCampaign_final_polling()
		{
			return null;
		}

		public static Handle WcsfCampaign_table_polling(int _room_id_, string _room_unique_id_)
		{
			return null;
		}

		public static Handle WcsfCampaign_watch_duel(int _room_id_, string _room_unique_id_, int _tno_, int _rapid_)
		{
			return null;
		}

		public static Handle WcsfCampaign_set_support_team(int _team_id_)
		{
			return null;
		}

		public static Handle WcsfCampaign_support_entry()
		{
			return null;
		}
	}
}
